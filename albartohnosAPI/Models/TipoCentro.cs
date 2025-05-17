using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace albartohnosAPI.Models;

[Table("TiposCentro")]
public partial class TipoCentro
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<CentroParada> Centrosparada { get; set; } = new List<CentroParada>();
}
