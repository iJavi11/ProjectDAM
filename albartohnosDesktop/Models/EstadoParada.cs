using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class EstadoParada
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public EstadoParada()
        {

        }
        public EstadoParada(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
