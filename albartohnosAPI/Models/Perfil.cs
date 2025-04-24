using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace albartohnosAPI.Models;

public partial class Perfil
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
