using Microsoft.EntityFrameworkCore;
using albartohnosAPI.Models;

namespace albartohnosAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
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

        // Aquí se agregarán automáticamente las clases generadas
    }
}
