using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class Parada
    {
        public int Id { get; set; }
        public string Ruta { get; set; } = null!;
        public string CentroParada { get; set; } = null!;
        public int Orden { get; set; }
        public int Estado { get; set; }
        public DateTime? FechaPrev { get; set; }

        public Parada()
        {

        }
        public Parada(int id, string ruta, string centroParada, int orden, int estado, DateTime? fechaPrev)
        {
            Id = id;
            Ruta = ruta;
            CentroParada = centroParada;
            Orden = orden;
            Estado = estado;
            FechaPrev = fechaPrev;
        }
    }
}
