using System;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.DTOs.Usuario;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class UsuarioImplementation : BaseRepository<Usuario>, IUsuarioRepository
    {

        private DbSet<Usuario> _dataset;

        public UsuarioImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Usuario>();
        }

        public async Task<Usuario> FindByEmail(string email)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }

        public async Task<bool> SetPassword(int id, UsuarioDTOPasswordUpdate usuario )
        {
            try
            {
                var entidade = await _dataset.FirstOrDefaultAsync(u => u.Id.Equals(id));
                if (entidade == null)
                {
                    return false;
                }
                entidade.DataAtualizacao = DateTime.UtcNow;
                entidade.Senha = Criptografia.Cripto(usuario.SenhaNova);
                _context.Entry(entidade).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public async Task<bool> ResetPassword(int id)
        {
            try
            {
                var entidade = await _dataset.FirstOrDefaultAsync(u => u.Id.Equals(id));
                if (entidade == null)
                {
                    return false;
                }
                entidade.DataAtualizacao = DateTime.UtcNow;
                entidade.Senha = Criptografia.Cripto(entidade.Email);
                _context.Entry(entidade).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }
    }
}
