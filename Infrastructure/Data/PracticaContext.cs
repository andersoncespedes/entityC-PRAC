using System.Reflection.Emit;
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class PracticaContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<TipoCliente> TipoClientes{ get; set; }
    public DbSet<ClienteProducto> ClienteProductos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Entity<TipoCliente>()
        .HasMany<Cliente>(c => c.Clientes)
        .WithOne(e => e.TipoCliente)
        .HasForeignKey(e => e.IdTipoClienteFk);

        modelBuilder.Entity<ClienteProducto> ( ).HasKey(sc => new { sc.IdProductoFk, sc.IdClienteFk });

        modelBuilder.Entity<ClienteProducto> ( )
            .HasOne< Producto >(sc => sc.Producto)
            .WithMany(s => s.ClienteProducto)
            .HasForeignKey(sc => sc.IdProductoFk);


        modelBuilder.Entity<ClienteProducto> ( )
            .HasOne<Cliente>(sc => sc.Cliente)
            .WithMany(s => s.ClienteProducto)
            .HasForeignKey(sc => sc.IdClienteFk);
        }
}

