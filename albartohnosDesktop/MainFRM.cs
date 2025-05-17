using albartohnosDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace albartohnosDesktop
{
    public partial class MainFRM : Form
    {
        private Usuario currentUser;
        private bool isLoggingOut;
        // CACHEAMOS DESDE AQUÍ TODAS LAS VARIABLES QUE NECESATAMOS & ASÍ SE DISMUNUIRÁ EL NÚMERO DE LLAMADAS A LA API
        private List<Perfil> perfiles;
        private List<EstadoRuta> estadosRuta;
        private List<EstadoParada> estadosParada;
        private List<EstadoPedido> estadosPedido;
        private List<TipoCentro> tiposCentro;
        private List<TipoPedido> tiposPedido;

        public MainFRM(Usuario usuario)
        {
            InitializeComponent();
            ObtenerCache();
            currentUser = usuario;
            isLoggingOut = false;

            // Establecer el mensaje de bienvenida
            lblWelcome.Text = $"Bienvenido {currentUser.Nombre}";

            // Establecer la fecha actual
            lblDate.Text = $"Estamos a día {DateTime.Now.ToString("dd/MM/yyyy, dddd")}";

            // Establecemos los módulos con permiso
            if (currentUser.Perfil != 1)
            {
                btnUsersModule.Enabled = false; // Botón de Usuarios
                btnWhModule.Enabled = false;   // Botón de Almacenes

                // Configurar ToolTip para botones deshabilitados
                toolTip.SetToolTip(btnUsersModule, "No tiene permiso sobre este módulo.");
                toolTip.SetToolTip(btnWhModule, "No tiene permiso sobre este módulo.");
            }
        }
        private async void ObtenerCache()
        {
            estadosRuta = await Negocio.ObtenerEstadosRuta();
            estadosParada = await Negocio.ObtenerEstadosParada();
            estadosPedido = await Negocio.ObtenerEstadosPedido();
            tiposCentro = await Negocio.ObtenerTiposCentro();
            tiposPedido = await Negocio.ObtenerTiposPedido();
        }
        private void tsmiLogOut_Click(object sender, EventArgs e)
        {
            this.isLoggingOut = true;

            // Mostrar el formulario de Login
            Application.OpenForms["LoginFRM"]?.Show();

            // Limpiamos el usuario cacheado
            currentUser = null;

            // Cerrar el formulario actual
            this.Close();
        }
        private void btnVehiclesModule_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario VehiculosFRM
            var vehiculosForm = new ListFRM.VehiculosFRM(currentUser);

            // Mostrar el formulario como una ventana modal
            vehiculosForm.ShowDialog();
        }
        private void btnWhModule_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario AlmacenesFRM
            var almacenesForm = new ListFRM.AlmacenesFRM(currentUser);

            // Mostrar el formulario como una ventana modal
            almacenesForm.ShowDialog();
        }
        private void btnStCentersModule_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario CentrosParadaFRM
            var centrosParadaForm = new ListFRM.CentrosParadaFRM(currentUser, tiposCentro);

            // Mostrar el formulario como una ventana modal
            centrosParadaForm.ShowDialog();
        }
        private void MainFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verificar si LoginFRM está abierto y cerrarlo
            var loginForm = Application.OpenForms["LoginFRM"];
            if (loginForm != null && !this.isLoggingOut)
            {
                loginForm.Close();
            }
            // Cerrar la aplicación si no hay más formularios abiertos
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
