using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace albartohnosAPI.Models;

[Table("Rutas")]
public partial class Ruta
{
    [Key]
    public string CodRuta { get; set; } = null!;
    [ForeignKey(nameof(EstadoNavigation))]
    public int Estado { get; set; }

    public string? Descripcion { get; set; }
    [ForeignKey(nameof(ConductorNavigation))]
    public string? Conductor { get; set; }
    [ForeignKey(nameof(VehiculoNavigation))]
    public string? Vehiculo { get; set; }

    public DateTime? FechaPrevInicio { get; set; }

    public DateTime? FechaPrevFin { get; set; }

    public virtual Usuario? ConductorNavigation { get; set; }

    public virtual EstadoRuta EstadoNavigation { get; set; } = null!;

    public virtual ICollection<HistoricoRuta> Historicoruta { get; set; } = new List<HistoricoRuta>();

    public virtual ICollection<Parada> Parada { get; set; } = new List<Parada>();

    public virtual Vehiculo? VehiculoNavigation { get; set; }
}
