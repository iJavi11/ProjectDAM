using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class Perfil
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public Perfil()
        {

        }
        public Perfil(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
