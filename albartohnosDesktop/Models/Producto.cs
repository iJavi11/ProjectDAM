using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class Producto
    {
        public string Sku { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public sbyte Activo { get; set; }

        public Producto()
        {

        }
        public Producto(string sku, string nombre, string? descripcion, sbyte activo)
        {
            Sku = sku;
            Nombre = nombre;
            Descripcion = descripcion;
            Activo = activo;
        }
    }
}
