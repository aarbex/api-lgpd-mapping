using System;
using System.Collections.Generic;
using Api.Domain.Entities;

namespace Api.Domain.Models
{
    public class PerfilModel
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

        private ICollection<Usuario> _usuarios;
        public virtual ICollection<Usuario> Usuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

    }
}

