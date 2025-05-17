using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class EstadoRuta
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public EstadoRuta()
        {
        }
        public EstadoRuta(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
