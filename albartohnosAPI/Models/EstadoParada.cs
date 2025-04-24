using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace albartohnosAPI.Models;

public partial class EstadoParada
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Parada> Parada { get; set; } = new List<Parada>();
}
