using System;
using Api.Domain.Entities;

namespace Api.Domain.Models
{
    public class UsuarioModel
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = (value == null ? _email : value); }
        }

        private string _senhaNova;
        public string SenhaNova
        {
            get { return _senhaNova; }
            set { _senhaNova = value; }
        }

        private bool _ativo;
        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }
        private DateTime _dataCadastro;
        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }

        private DateTime _dataAtualizacao;
        public DateTime DataAtualizacao
        {
            get { return _dataAtualizacao; }
            set { _dataAtualizacao = value; }
        }

        private int _perfilID;
        public int PerfilID
        {
            get { return _perfilID; }
            set { _perfilID = value; }
        }

        private Perfil _perfil;
        public virtual Perfil Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }


    }
}
