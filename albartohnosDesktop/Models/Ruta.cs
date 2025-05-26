using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class Ruta
    {
        public string CodRuta { get; set; } = null!;
        public int Estado { get; set; }
        public string? Descripcion { get; set; }
        public string? Conductor { get; set; }
        public string? Vehiculo { get; set; }
        public DateTime? FechaPrevInicio { get; set; }
        public DateTime? FechaPrevFin { get; set; }

        public Ruta()
        {
            
        }
        public Ruta(string codRuta, int estado, string? descripcion, string? conductor, string? vehiculo, DateTime? fechaPrevInicio, DateTime? fechaPrevFin)
        {
            CodRuta = codRuta;
            Estado = estado;
            Descripcion = descripcion;
            Conductor = conductor;
            Vehiculo = vehiculo;
            FechaPrevInicio = fechaPrevInicio;
            FechaPrevFin = fechaPrevFin;
        }
    }
}
