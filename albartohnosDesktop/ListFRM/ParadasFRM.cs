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
    public partial class ParadasFRM : Form
    {
        private Usuario currentUser;
        private string ruta;
        private List<Parada> paradas;
        // Aquí van los datos que van cacheados del Módulo de Rutas
        private List<EstadoParada> estadosParada;
        private List<EstadoPedido> estadosPedido;
        private List<TipoPedido> tiposPedido;
        // Aquí van otros datos necesarios
        private List<CentroParada> centrosParada;

        public ParadasFRM()
        {
            InitializeComponent();
        }
        public ParadasFRM(Usuario usuario, string codRuta, List<EstadoParada> estadosParada, List<EstadoPedido> estadosPedido, List<TipoPedido> tiposPedido) : this()
        {
            currentUser = usuario;
            ruta = codRuta;
            this.estadosParada = estadosParada;
            this.estadosPedido = estadosPedido;
            this.tiposPedido = tiposPedido;

            lblTitle.Text = $"Paradas de {ruta}";

            // Inicializar la lista de paradas de la ruta seleccionada
            ReloadStopList();

            //Permisos de usuario


            this.FormClosed += ParadasFRM_FormClosed;
        }

        private async void ReloadStopList()
        {
            paradas = await Negocio.ObtenerParadasByRuta(ruta);
            centrosParada = await Negocio.ObtenerCentrosParada();

            // Limpiamos el ListView antes de añadir nada
            lvStops.Items.Clear();

            // Iteramos sobre la lista de rutas y las añadimos al ListView
            foreach (var parada in paradas)
            {
                ListViewItem item = new ListViewItem(parada.Orden.ToString());
                item.SubItems.Add(estadosParada.FirstOrDefault(e => e.Id == parada.Estado)?.Nombre ?? "");
                item.SubItems.Add(parada.CentroParada);
                item.SubItems.Add(centrosParada.FirstOrDefault(cp => cp.Id == parada.CentroParada)?.Nombre ?? "");
                item.SubItems.Add(parada.FechaPrev.ToString());

                item.Tag = parada;

                lvStops.Items.Add(item);
            }
        }
        private void btnUpdateStop_Click(object sender, EventArgs e)
        {
            ReloadStopList();
        }
        private async void btnCreateStop_Click(object sender, EventArgs e)
        {
            Parada parada = new Parada();

            parada.Ruta = ruta; // Ruta a la que pertenece la parada
            parada.Estado = 1; // Estado Pendiente
            parada.Orden = lvStops.Items.Count + 1; // Asignar orden basado en el número de paradas existentes

            ParadaFRM ventana = new ParadaFRM(parada, estadosParada, centrosParada);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.CrearParada(parada);
                this.ReloadStopList();
            }
        }
        private async void tsmiEditarParada_Click(object sender, EventArgs e)
        {
            Parada parada = (Parada)lvStops.SelectedItems[0].Tag;
            ParadaFRM ventana = new ParadaFRM(parada, estadosParada, centrosParada);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.EditarParada(parada);
                this.ReloadStopList();
            }
        }
        private void tsmiVerPedidosParada_Click(object sender, EventArgs e)
        {
            Parada parada = (Parada)lvStops.SelectedItems[0].Tag;
            // Crear una instancia del formulario StockFRM
            var pedidosForm = new PedidosFRM(currentUser, parada.Id, estadosPedido, tiposPedido);

            // Mostrar el formulario como una ventana modal
            pedidosForm.ShowDialog();
        }
        private async void tsmiParadaEnProgreso_Click(object sender, EventArgs e)
        {
            Parada parada = (Parada)lvStops.SelectedItems[0].Tag;

            parada.Estado = 2;

            await Negocio.EditarParada(parada);
            this.ReloadStopList();
        }
        private async void tsmiParadaOK_Click(object sender, EventArgs e)
        {
            Parada parada = (Parada)lvStops.SelectedItems[0].Tag;

            parada.Estado = 3;

            await Negocio.EditarParada(parada);
            this.ReloadStopList();
        }
        private async void tsmiParadaKO_Click(object sender, EventArgs e)
        {
            Parada parada = (Parada)lvStops.SelectedItems[0].Tag;

            parada.Estado = 4;

            await Negocio.EditarParada(parada);
            this.ReloadStopList();
        }
        private async void tsmiEliminarParada_Click(object sender, EventArgs e)
        {
            Parada parada = (Parada)lvStops.SelectedItems[0].Tag;
            if (MessageBox.Show(
                    $"¿Está seguro de que desea eliminar la parada?\n" +
                    $"Ten en cuenta que solo se puede eliminar paradas que no tengan vinculados ningún pedido.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                ) == DialogResult.Yes
            )
            {
                await Negocio.BorrarParada(parada.Id);
                this.ReloadStopList();
            }
        }
        private void ParadasFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // FUNCIONALIDADES
        private void cmsMenuStop_Opening(object sender, CancelEventArgs e)
        {
            if (lvStops.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
        }
        private void lvStops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStops.SelectedItems.Count != 0)
            {
                tsmiEditarParada.Enabled = true;
                tsmiVerPedidosParada.Enabled = true;
                tsmiCambiarEstadoParada.Enabled = true;
                tsmiParadaEnProgreso.Enabled = true;
                tsmiParadaOK.Enabled = true;
                tsmiParadaKO.Enabled = true;
            }
            else
            {
                tsmiEditarParada.Enabled = false;
                tsmiVerPedidosParada.Enabled = false;
                tsmiCambiarEstadoParada.Enabled = false;
                tsmiParadaEnProgreso.Enabled = false;
                tsmiParadaOK.Enabled = false;
                tsmiParadaKO.Enabled = false;
            }
        }
        private void lvStops_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void lvStops_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
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
                    case "Pendiente":
                        backColor = Color.Yellow;
                        break;

                    case "En Progreso":
                        backColor = Color.LightBlue;
                        break;

                    case "OK":
                        backColor = Color.LightGreen;
                        break;

                    case "KO":
                        backColor = Color.Red;
                        foreColor = Color.White;
                        break;
                }

                using (SolidBrush backgroundBrush = new SolidBrush(backColor))
                using (SolidBrush textBrush = new SolidBrush(foreColor))
                {
                    e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                    e.Graphics.DrawString(e.SubItem.Text, lvStops.Font, textBrush, e.Bounds);
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
