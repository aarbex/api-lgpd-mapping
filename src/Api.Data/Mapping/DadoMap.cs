using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class DadoMap : IEntityTypeConfiguration<Dado>
    {
        public void Configure(EntityTypeBuilder<Dado> builder)
        {
            builder.ToTable("Dado");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).IsRequired().HasMaxLength(60);

            builder.Property(p => p.Categoria).IsRequired();

            builder.Property(p => p.DataMappingID).IsRequired();

            builder.HasOne<DataMapping>(d => d.DataMapping)
                .WithMany(p => p.Dados)
                .HasForeignKey(u => u.DataMappingID);
        }
    }
}
