using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace albartohnosAPI.Models;

[Table("Vehiculos")]
public partial class Vehiculo
{
    [Key]
    public string Matricula { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Capacidad { get; set; }

    public sbyte Activo { get; set; }

    [Column("Fecha_Alta")]
    public DateOnly? FechaAlta { get; set; }

    [Column("Fecha_Baja")]
    public DateOnly? FechaBaja { get; set; }

    public virtual ICollection<Ruta> Rutas { get; set; } = new List<Ruta>();
}
