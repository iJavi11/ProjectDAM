using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace albartohnosAPI.Models;

[Table("Pedidos")]
public partial class Pedido
{
    [Key]
    public string CodPedido { get; set; } = null!;
    [ForeignKey(nameof(SkuProductoNavigation))]
    public string SkuProducto { get; set; } = null!;
    [ForeignKey(nameof(TipoNavigation))]
    public int Tipo { get; set; }
    [ForeignKey(nameof(EstadoNavigation))]
    public int Estado { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }
    [ForeignKey(nameof(IdParadaNavigation))]
    public int? IdParada { get; set; }

    public virtual EstadoPedido? EstadoNavigation { get; set; }

    public virtual Parada? IdParadaNavigation { get; set; }

    public virtual Producto? SkuProductoNavigation { get; set; }

    public virtual TipoPedido? TipoNavigation { get; set; }
}
