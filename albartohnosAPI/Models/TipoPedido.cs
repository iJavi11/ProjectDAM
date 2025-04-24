using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace albartohnosAPI.Models;

public partial class TipoPedido
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
