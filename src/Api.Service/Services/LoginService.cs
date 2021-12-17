using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Api.Domain.DTOs;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.UsuarioService;
using Api.Domain.Repository;
using Api.Domain.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUsuarioRepository _repository;

        private SigningConfigurations _signingConfigurations;

        private TokenConfiguration _tokenConfiguration;

        private IConfiguration _configuration { get; }

        public LoginService(IUsuarioRepository repository,
                            SigningConfigurations signingConfigurations,
                            TokenConfiguration tokenConfiguration,
                            IConfiguration configuration)
        {
            _repository = repository;
            _signingConfigurations = signingConfigurations;
            _tokenConfiguration = tokenConfiguration;
            _configuration = configuration;
        }



        public async Task<object> FindByEmail(LoginDTO login)
        {

            var baseUsuario = new Usuario();

            if (login != null && (!string.IsNullOrWhiteSpace(login.Email) || !string.IsNullOrWhiteSpace(login.Senha)))
            {
                baseUsuario = await _repository.FindByEmail(login.Email);
                if (baseUsuario == null)
                {
                    return new
                    {
                        authenticated = false,
                        message = "Falha ao autenticar!"
                    };
                }
                else
                {
                    if(baseUsuario.Ativo != true)
                    {
                        return new
                        {
                            authenticated = false,
                            message = "O usuário informado está inativo!"
                        };
                    }
                    var senhaCripto = Criptografia.Cripto(login.Senha);
                    if(senhaCripto == baseUsuario.Senha){
                        ClaimsIdentity identity = new ClaimsIdentity(
                        new GenericIdentity(login.Email),
                        new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.UniqueName, login.Email),
                        }
                    );

                        DateTime dataCriacao = DateTime.Now;
                        DateTime dataExpiracao = (dataCriacao + TimeSpan.FromSeconds(_tokenConfiguration.Seconds));

                        var handler = new JwtSecurityTokenHandler();

                        string token = CreateToken(identity, dataCriacao, dataExpiracao, handler);

                        return SuccessObject(dataCriacao, dataExpiracao, token, baseUsuario);
                    }
                    else{
                        return new
                        {
                            authenticated = false,
                            message = "O usuário e/ou a senha não conferem!"
                        };
                    }

                }
            }
            else
            {
                return new
                    {
                        authenticated = false,
                        message = "Falha ao autenticar!"
                    };
            }

        }

        private string CreateToken(ClaimsIdentity identity, DateTime dataCriacao, DateTime dataExpiracao, JwtSecurityTokenHandler handler){
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _tokenConfiguration.Issuer,
                Audience = _tokenConfiguration.Audience,
                SigningCredentials = _signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = dataCriacao,
                Expires = dataExpiracao
            });

            var token = handler.WriteToken(securityToken);

            return token;
        }

        private object SuccessObject(DateTime dataCriacao, DateTime dataExpiracao, string token, Usuario usuario)
        {
            return new
            {
                authenticated = true,
                created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                accessToken = token,
                user = new {nome = usuario.Nome,
                            email = usuario.Email},
                message = "Usuário logado com sucesso!"
            };
        }
    }
}
