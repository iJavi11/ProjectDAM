using albartohnosDesktop.CreateUpdateFRM;
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

namespace albartohnosDesktop.ListFRM
{
    public partial class RutasFRM : Form
    {
        private Usuario currentUser;
        private List<Ruta> rutas;
        // Aquí van los datos que están cacheados del Menú Principal
        private List<EstadoRuta> estadosRuta;
        private List<EstadoParada> estadosParada;
        private List<EstadoPedido> estadosPedido;
        private List<TipoPedido> tiposPedido;

        public RutasFRM()
        {
            InitializeComponent();
        }
        public RutasFRM(Usuario usuario, List<EstadoRuta> estadosRuta, List<EstadoParada> estadosParada, List<EstadoPedido> estadosPedido, List<TipoPedido> tiposPedido) : this()
        {
            currentUser = usuario;
            this.estadosRuta = estadosRuta;
            this.estadosParada = estadosParada;
            this.estadosPedido = estadosPedido;
            this.tiposPedido = tiposPedido;

            // Inicializar la lista de rutas
            ReloadRouteList();

            // Permisos de usuario

            
            this.FormClosed += RutasFRM_FormClosed;
        }

        private async void ReloadRouteList()
        {
            rutas = await Negocio.ObtenerRutas();

            // Limpiamos el ListView antes de añadir nada
            lvRoutes.Items.Clear();

            // Iteramos sobre la lista de rutas y las añadimos al ListView
            foreach (var ruta in rutas)
            {
                ListViewItem item = new ListViewItem(ruta.CodRuta);
                item.SubItems.Add(estadosRuta.FirstOrDefault(e => e.Id == ruta.Estado)?.Nombre ?? "");
                item.SubItems.Add(ruta.Descripcion);
                item.SubItems.Add(ruta.Conductor);
                item.SubItems.Add(ruta.Vehiculo);
                item.SubItems.Add(ruta.FechaPrevInicio.ToString());
                item.SubItems.Add(ruta.FechaPrevFin.ToString());

                item.Tag = ruta;

                lvRoutes.Items.Add(item);
            }
        }
        private void btnUpdateRoutes_Click(object sender, EventArgs e)
        {
            ReloadRouteList();
        }
        private async void btnCreateRoute_Click(object sender, EventArgs e)
        {
            List<Usuario> conductores = await Negocio.ObtenerConductoresActivos();
            List<Vehiculo> vehiculos = await Negocio.ObtenerVehiculosActivos();

            Ruta ruta = new Ruta();
            ruta.Estado = 1; // Estado Creada
            RutaFRM ventana = new RutaFRM(ruta, estadosRuta, conductores, vehiculos);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.CrearRuta(ruta);
                this.ReloadRouteList();
            }
        }
        private async void tsmiEditarRuta_Click(object sender, EventArgs e)
        {
            List<Usuario> conductores = await Negocio.ObtenerConductoresActivos();
            List<Vehiculo> vehiculos = await Negocio.ObtenerVehiculosActivos();

            Ruta ruta = (Ruta)lvRoutes.SelectedItems[0].Tag;
            RutaFRM ventana = new RutaFRM(ruta, estadosRuta, conductores, vehiculos);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.EditarRuta(ruta);
                this.ReloadRouteList();
            }
        }
        private void tsmiVerParadasRuta_Click(object sender, EventArgs e)
        {
            Ruta ruta = (Ruta)lvRoutes.SelectedItems[0].Tag;
            // Crear una instancia del formulario StockFRM
            var paradasForm = new ParadasFRM(currentUser, ruta.CodRuta, estadosParada, estadosPedido, tiposPedido);

            // Mostrar el formulario como una ventana modal
            paradasForm.ShowDialog();
        }
        private async void tsmiRutaPlanificada_Click(object sender, EventArgs e)
        {
            Ruta ruta = (Ruta)lvRoutes.SelectedItems[0].Tag;

            ruta.Estado = 2;

            await Negocio.EditarRuta(ruta);
            this.ReloadRouteList();
        }
        private async void tsmiRutaEnProgreso_Click(object sender, EventArgs e)
        {
            Ruta ruta = (Ruta)lvRoutes.SelectedItems[0].Tag;

            ruta.Estado = 3;

            await Negocio.EditarRuta(ruta);
            this.ReloadRouteList();
        }
        private async void tsmiRutaFinalizada_Click(object sender, EventArgs e)
        {
            Ruta ruta = (Ruta)lvRoutes.SelectedItems[0].Tag;

            ruta.Estado = 4;

            await Negocio.EditarRuta(ruta);
            this.ReloadRouteList();
        }
        private async void tsmiEliminarRuta_Click(object sender, EventArgs e)
        {
            Ruta ruta = (Ruta)lvRoutes.SelectedItems[0].Tag;
            if (MessageBox.Show(
                    $"¿Está seguro de que desea eliminar la ruta?\n" +
                    $"Ten en cuenta que solo se puede eliminar rutas que no tengan vinculados ninguna parada.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                ) == DialogResult.Yes
            )
            {
                await Negocio.BorrarRuta(ruta.CodRuta);
                this.ReloadRouteList();
            }
        }
        private void RutasFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // FUNCIONALIDADES
        private void cmsMenuRoute_Opening(object sender, CancelEventArgs e)
        {
            if (lvRoutes.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
        }
        private void lvRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRoutes.SelectedItems.Count != 0)
            {
                tsmiEditarRuta.Enabled = true;
                tsmiVerParadasRuta.Enabled = true;
                tsmiCambiarEstadoRuta.Enabled = true;
                tsmiRutaPlanificada.Enabled = true;
                tsmiRutaEnProgreso.Enabled = true;
                tsmiRutaFinalizada.Enabled = true;
            }
            else
            {
                tsmiEditarRuta.Enabled = false;
                tsmiVerParadasRuta.Enabled = false;
                tsmiCambiarEstadoRuta.Enabled = false;
                tsmiRutaPlanificada.Enabled = false;
                tsmiRutaEnProgreso.Enabled = false;
                tsmiRutaFinalizada.Enabled = false;
            }
        }
        private void lvRoutes_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void lvRoutes_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Índice de la columna de estados
            int estadoColIndex = 1;

            if (e.ColumnIndex == estadoColIndex)
            {
                // Ejemplo: cambia el color según el texto del estado
                Color backColor = Color.White;
                Color foreColor = Color.Black;

                switch (e.SubItem.Text)
                {
                    case "Creada":
                        backColor = Color.Yellow;
                        break;

                    case "Planificada":
                        backColor = Color.LightBlue;
                        break;

                    case "En Progreso":
                        backColor = Color.LightGreen;
                        break;

                    case "Finalizada":
                        backColor = Color.Red;
                        foreColor = Color.White;
                        break;
                }

                using (SolidBrush backgroundBrush = new SolidBrush(backColor))
                using (SolidBrush textBrush = new SolidBrush(foreColor))
                {
                    e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                    e.Graphics.DrawString(e.SubItem.Text, lvRoutes.Font, textBrush, e.Bounds);
                }
            }
            else
            {
                // Dibuja normalmente el resto de columnas
                e.DrawDefault = true;
            }
        }
    }
}
