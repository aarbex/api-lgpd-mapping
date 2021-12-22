using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ControladorMap : IEntityTypeConfiguration<Controlador>
    {
        public void Configure(EntityTypeBuilder<Controlador> builder)
        {
            builder.ToTable("Controlador");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.RazaoSocial).IsRequired().HasMaxLength(100);

            builder.Property(p => p.NomeFantasia).IsRequired().HasMaxLength(100);

            builder.Property(p => p.CNPJ).IsRequired().HasMaxLength(14);

            builder.Property(p => p.Telefone).IsRequired().HasMaxLength(15);

            builder.Property(p => p.TelefoneAdicional).HasMaxLength(15);

            builder.Property(p => p.CEP).IsRequired().HasMaxLength(9);

            builder.Property(p => p.Logradouro).IsRequired().HasMaxLength(100);

            builder.Property(p => p.Numero);

            builder.Property(p => p.Complemento).HasMaxLength(50);

            builder.Property(p => p.Bairro).IsRequired().HasMaxLength(100);

            builder.Property(p => p.Localidade).IsRequired().HasMaxLength(100);

            builder.Property(p => p.UF).IsRequired().HasMaxLength(2);
        }
    }
}
