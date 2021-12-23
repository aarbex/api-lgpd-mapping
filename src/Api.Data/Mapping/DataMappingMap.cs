using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class DataMappingMap : IEntityTypeConfiguration<DataMapping>
    {
        public void Configure(EntityTypeBuilder<DataMapping> builder)
        {
            builder.ToTable("DataMapping");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Area).IsRequired().HasMaxLength(50);

            builder.Property(p => p.Processo).IsRequired().HasMaxLength(50);

            builder.Property(p => p.DonoProcesso).IsRequired().HasMaxLength(50);

            builder.Property(p => p.Origem).IsRequired();

            builder.Property(p => p.BaseLegal).IsRequired();

            builder.Property(p => p.DadosCriancasAdolescentes).IsRequired();

            builder.Property(p => p.Formato).IsRequired();

            builder.Property(p => p.Frequencia).IsRequired();

            builder.Property(p => p.Tratamento).IsRequired();

            builder.Property(p => p.NaturezaTitular).IsRequired();

            builder.Property(p => p.MesReferencia).IsRequired().HasMaxLength(10);

            builder.Property(p => p.AnoReferencia).IsRequired().HasMaxLength(4);
        }
    }
}
