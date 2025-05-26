using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class Stock
    {
        public string IdAlmacen { get; set; } = null!;
        public string SkuProducto { get; set; } = null!;
        public int Cantidad { get; set; }

        public Stock() 
        { 

        }
        public Stock(string idAlmacen, string skuProducto, int cantidad)
        {
            IdAlmacen = idAlmacen;
            SkuProducto = skuProducto;
            Cantidad = cantidad;
        }
    }
}
