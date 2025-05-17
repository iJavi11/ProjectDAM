using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albartohnosDesktop.Models
{
    public partial class Usuario
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Perfil { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string? Nss { get; set; }
        public string? Tlf { get; set; }
        public string? Email { get; set; }
        public string? Ccaa { get; set; }
        public string? Localidad { get; set; }
        public string? Direccion { get; set; }
        public sbyte Activo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public Usuario()
        {

        }

        public Usuario(string login, string password, int perfil, string nombre, string apellidos, string dni, string nss, string tlf, string email, string ccaa, string localidad, string direccion, sbyte activo, DateTime? fechaAlta, DateTime? fechaBaja)
        {
            Login = login;
            Password = password;
            Perfil = perfil;
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
            Nss = nss;
            Tlf = tlf;
            Email = email;
            Ccaa = ccaa;
            Localidad = localidad;
            Direccion = direccion;
            Activo = activo;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
        }
    }
}
