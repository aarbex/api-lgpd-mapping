using System;

namespace Api.Domain.DTOs.Parametros.Categoria
{
    public class CategoriaDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
