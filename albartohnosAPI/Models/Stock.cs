using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace albartohnosAPI.Models;

[PrimaryKey(nameof(IdAlmacen), nameof(SkuProducto))]
public partial class Stock
{
    [ForeignKey(nameof(IdAlmacenNavigation))]
    public string IdAlmacen { get; set; } = null!;

    [ForeignKey(nameof(SkuProductoNavigation))]
    public string SkuProducto { get; set; } = null!;

    public int Cantidad { get; set; }

    public virtual CentroParada IdAlmacenNavigation { get; set; } = null!;

    public virtual Producto SkuProductoNavigation { get; set; } = null!;
}
