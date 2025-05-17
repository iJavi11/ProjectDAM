using Microsoft.EntityFrameworkCore;
using albartohnosAPI.Models;
using System;

namespace albartohnosAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Aquí se agregarán automáticamente las clases generadas
        public DbSet<albartohnosAPI.Models.Usuario> Usuario { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.Vehiculo> Vehiculo { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.TipoPedido> TipoPedido { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.TipoCentro> TipoCentro { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.Stock> Stock { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.Ruta> Ruta { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.Producto> Producto { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.Perfil> Perfil { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.Pedido> Pedido { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.Parada> Parada { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.HistoricoRuta> HistoricoRuta { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.EstadoRuta> EstadoRuta { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.EstadoPedido> EstadoPedido { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.EstadoParada> EstadoParada { get; set; } = default!;
        public DbSet<albartohnosAPI.Models.CentroParada> CentroParada { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;Database=albertobartolomehnos;User=root;Password=Nagato@24!;",
                new MySqlServerVersion(new Version(8, 0, 32)) // Cambia por la versión de tu servidor MySQL
            );
            // optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
