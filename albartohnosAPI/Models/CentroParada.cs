using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace albartohnosAPI.Models;

[Table("CentrosParada")]
public partial class CentroParada
{
    [Key]
    public string Id { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    [ForeignKey(nameof(TipoCentroNavigation))] // Configura la clave foránea
    public int TipoCentro { get; set; }

    public string? Tlf { get; set; }

    public string? Email { get; set; }

    public string? Ccaa { get; set; }

    public string? Localidad { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Parada> Parada { get; set; } = new List<Parada>();

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    public virtual TipoCentro TipoCentroNavigation { get; set; } = null!;
}
