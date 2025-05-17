using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class Vehiculo
    {
        public string Matricula { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal? Capacidad { get; set; }
        public sbyte Activo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public Vehiculo()
        {

        }
        public Vehiculo(string matricula, string marca, string modelo, string descripcion, decimal? capacidad, sbyte activo, DateTime? fechaAlta, DateTime? fechaBaja)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Descripcion = descripcion;
            Capacidad = capacidad;
            Activo = activo;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
        }
    }
}
