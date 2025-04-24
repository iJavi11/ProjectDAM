using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace albartohnosAPI.Models;

public partial class Vehiculo
{
    [Key]
    public string Matricula { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Capacidad { get; set; }

    public sbyte Activo { get; set; }

    public DateOnly? FechaAlta { get; set; }

    public DateOnly? FechaBaja { get; set; }

    public virtual ICollection<Ruta> Ruta { get; set; } = new List<Ruta>();
}
