using Api.Domain.Entities.Parametros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping.Parametros
{
    public class FormatoMap : IEntityTypeConfiguration<Formato>
    {
        public void Configure(EntityTypeBuilder<Formato> builder)
        {
            builder.ToTable("Formato");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).IsRequired().HasMaxLength(60);

            builder.Property(p => p.Descricao).HasMaxLength(255);
        }
    }
}
