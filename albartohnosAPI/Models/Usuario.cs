using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace albartohnosAPI.Models;

public partial class Usuario
{
    [Key]
    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
    [ForeignKey(nameof(PerfilNavigation))]
    public int Perfil { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string? Nss { get; set; }

    public string? Tlf { get; set; }

    public string? Email { get; set; }

    public string? Ccaa { get; set; }

    public string? Localidad { get; set; }

    public string? Direccion { get; set; }

    public sbyte Activo { get; set; }

    public DateOnly? FechaAlta { get; set; }

    public DateOnly? FechaBaja { get; set; }

    public virtual Perfil PerfilNavigation { get; set; } = null!;

    public virtual ICollection<Ruta> Ruta { get; set; } = new List<Ruta>();
}
