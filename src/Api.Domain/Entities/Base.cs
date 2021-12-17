using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public abstract class Base
    {
        [Key]
        public int Id { get; set; }

        private bool? _ativo;
        public bool? Ativo
        {
            get { return _ativo; }
            set { _ativo = ( value == null ? true : value) ; }
        }


        private DateTime? _dataCadastro;
        public DateTime? DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = (value == null ? DateTime.UtcNow : value);  }

        }

        public DateTime? DataAtualizacao { get; set; }
    }
}
