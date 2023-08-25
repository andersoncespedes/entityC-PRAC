using System.Collections.Immutable;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
        public void Configure(EntityTypeBuilder<Cliente> builder){
            builder.ToTable("cliente");
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(20);
            builder.Property(e => e.Apellido).IsRequired().HasMaxLength(20);
            builder.Property(e => e.Cedula).IsRequired().HasMaxLength(20);
            builder.HasIndex(e => e.Cedula).IsUnique();
        }
}
