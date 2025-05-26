using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace albartohnosAPI.Models;

[Table("Paradas")]
public partial class Parada
{
    [Key]
    public int Id { get; set; }
    [ForeignKey(nameof(RutaNavigation))]
    public string Ruta { get; set; } = null!;
    [ForeignKey(nameof(CentroParadaNavigation))]
    public string CentroParada { get; set; } = null!;

    public int Orden { get; set; }
    [ForeignKey(nameof(EstadoNavigation))]
    public int Estado { get; set; }

    public DateTime? FechaPrev { get; set; }

    public virtual CentroParada? CentroParadaNavigation { get; set; }

    public virtual EstadoParada? EstadoNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual Ruta? RutaNavigation { get; set; }
}
