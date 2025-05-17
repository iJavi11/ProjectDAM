using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class CentroParada
    {
        public string Id { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int TipoCentro { get; set; }
        public string? Tlf { get; set; }
        public string? Email { get; set; }
        public string? Ccaa { get; set; }
        public string? Localidad { get; set; }
        public string? Direccion { get; set; }

        public CentroParada() 
        {

        }
        public CentroParada(string id, string nombre, int tipoCentro, string? tlf, string? email, string? ccaa, string? localidad, string? direccion)
        {
            Id = id;
            Nombre = nombre;
            TipoCentro = tipoCentro;
            Tlf = tlf;
            Email = email;
            Ccaa = ccaa;
            Localidad = localidad;
            Direccion = direccion;
        }
    }
}
