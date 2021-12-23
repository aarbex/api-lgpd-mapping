using System;
using Api.Domain.Entities;
using Api.Domain.Enums;

namespace Api.Domain.Models
{
    public class DadoModel
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


        private CategoriaEnum _categoria;
        public CategoriaEnum Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private int _dataMappingID;
        public int DataMappingID
        {
            get { return _dataMappingID; }
            set { _dataMappingID = value; }
        }

        private DataMapping _dataMapping;
        public virtual DataMapping DataMapping
        {
            get { return _dataMapping; }
            set { _dataMapping = value; }
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
    }
}
