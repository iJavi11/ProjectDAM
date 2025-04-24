using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace albartohnosAPI.Models;

public partial class HistoricoRuta
{
    [Key]
    public int Id { get; set; }
    [ForeignKey(nameof(RutaNavigation))]
    public string Ruta { get; set; } = null!;

    public string Conductor { get; set; } = null!;

    public string Vehiculo { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public virtual Ruta RutaNavigation { get; set; } = null!;
}
