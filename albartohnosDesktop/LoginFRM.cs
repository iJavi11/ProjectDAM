using albartohnosDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace albartohnosDesktop
{
    public partial class LoginFRM : Form
    {
        public LoginFRM()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Validación de credenciales
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Por favor, ingrese usuario y contraseña.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Una vez pasada la validación, procedemos a el intento de inicio de sesión a través de la API
            string username = txtUser.Text;
            string password = Encriptador(txtPassword.Text);

            string response = await Negocio.IniciarSesion(username, password);

            if (!string.IsNullOrEmpty(response))
            {
                if (response != "Successfully authenticated")
                {
                    MessageBox.Show(response);
                    return;
                }

                // MessageBox.Show("Login successful!");

                // Obtenemos el usuario con el que se ha inciado la sesión
                Usuario usuario = await Negocio.ObtenerUsuario(username);

                // Validaciones de perfiles y usuarios activos
                if (usuario.Perfil == 3)
                {
                    MessageBox.Show("El usuario no tiene permisos sobre este aplicativo");
                    return;
                }

                if(usuario.Activo == 0)
                {
                    MessageBox.Show("El usuario está deshabilitado. Consulte con un Administrador");
                    return;
                }

                MainFRM mainForm = new MainFRM(usuario);
                mainForm.Show();

                // Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Server Error, Empty Response.");
            }
        }

        // Método para encriptar la contraseña 
        public static string Encriptador(string password)
        {
            // HashtoSHA256
            byte[] bytes = Encoding.UTF8.GetBytes(password);

            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;

            foreach (byte x in hash)
            {
                hashString += string.Format("{0:x2}", x);
            }

            return hashString;
        }
    }
}
