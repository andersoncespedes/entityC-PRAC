using System.Collections.Immutable;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Data.Configuration;

    public class TipoClienteConfiguration : IEntityTypeConfiguration<TipoCliente>
    {
        public void Configure(EntityTypeBuilder<TipoCliente> builder){
            builder.Property(e => e.Descripcion).IsRequired().HasMaxLength(20);
        }
    }
