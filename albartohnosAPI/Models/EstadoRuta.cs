using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace albartohnosAPI.Models;

public partial class EstadoRuta
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Ruta> Ruta { get; set; } = new List<Ruta>();
}
