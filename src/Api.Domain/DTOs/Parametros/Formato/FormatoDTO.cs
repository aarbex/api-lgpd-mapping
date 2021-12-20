using System;

namespace Api.Domain.DTOs.Parametros.Formato
{
    public class FormatoDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
