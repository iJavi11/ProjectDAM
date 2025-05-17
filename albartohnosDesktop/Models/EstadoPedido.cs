using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class EstadoPedido
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public EstadoPedido()
        {

        }
        public EstadoPedido(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
