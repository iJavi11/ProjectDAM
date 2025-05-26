using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class Pedido
    {
        public string CodPedido { get; set; } = null!;
        public string SkuProducto { get; set; } = null!;
        public int Tipo { get; set; }
        public int Estado { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int? IdParada { get; set; }

        public Pedido()
        {

        }
        public Pedido(string codPedido, string skuProducto, int tipo, int estado, int cantidad, decimal precio, int? idParada)
        {
            CodPedido = codPedido;
            SkuProducto = skuProducto;
            Tipo = tipo;
            Estado = estado;
            Cantidad = cantidad;
            Precio = precio;
            IdParada = idParada;
        }
    }
}
