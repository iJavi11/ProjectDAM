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
    public partial class PedidosFRM : Form
    {
        private Usuario currentUser;
        private int parada;
        private List<Pedido> pedidos;
        // Aquí van los datos que están cacheados del Módulo de Paradas
        private List<EstadoPedido> estadosPedido;
        private List<TipoPedido> tiposPedido;
        // Aquí van otros datos necesarios
        private List<Producto> productos;

        public PedidosFRM()
        {
            InitializeComponent();
        }
        public PedidosFRM(Usuario usuario, int parada, List<EstadoPedido> estadosPedido, List<TipoPedido> tiposPedido) : this()
        {
            currentUser = usuario;
            this.parada = parada;
            this.estadosPedido = estadosPedido;
            this.tiposPedido = tiposPedido;

            // Inicializar la lista de pedidos de la parada seleccionada
            this.ReloadOrderList();

            // Permisos de usuario


            this.FormClosed += PedidosFRM_FormClosed;
        }

        private async void ReloadOrderList()
        {
            pedidos = await Negocio.ObtenerPedidosByParada(parada);
            productos = await Negocio.ObtenerProductos();

            // Limpiamos el ListView antes de añadir nada
            lvOrders.Items.Clear();

            // Iteramos sobre la lista de pedidos y los añadimos al ListView
            foreach (var pedido in pedidos)
            {
                ListViewItem item = new ListViewItem(pedido.CodPedido);
                item.SubItems.Add(productos.FirstOrDefault(p => p.Sku == pedido.SkuProducto)?.Nombre ?? "");
                item.SubItems.Add(tiposPedido.FirstOrDefault(tp => tp.Id == pedido.Tipo)?.Nombre ?? "");
                item.SubItems.Add(estadosPedido.FirstOrDefault(ep => ep.Id == pedido.Estado)?.Nombre ?? "");
                item.SubItems.Add(pedido.Cantidad.ToString());
                item.SubItems.Add(pedido.Precio.ToString());

                item.Tag = pedido;

                lvOrders.Items.Add(item);
            }
        }
        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
            this.ReloadOrderList();
        }
        private async void btnCreateOrders_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();

            pedido.Estado = 1;
            pedido.IdParada = parada;

            PedidoFRM ventana = new PedidoFRM(pedido, estadosPedido, tiposPedido, productos.Where(p => p.Activo == 1).ToList());
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.CrearPedido(pedido);
                this.ReloadOrderList();
            }
        }
        private async void tsmiEditarPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)lvOrders.SelectedItems[0].Tag;
            PedidoFRM ventana = new PedidoFRM(pedido, estadosPedido, tiposPedido, productos.Where(p => p.Activo == 1).ToList());
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.CrearPedido(pedido);
                this.ReloadOrderList();
            }
        }
        private async void tsmiPedidoOK_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)lvOrders.SelectedItems[0].Tag;

            pedido.Estado = 2;

            await Negocio.EditarPedido(pedido);
            this.ReloadOrderList();
        }
        private async void tsmiPedidoParcial_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)lvOrders.SelectedItems[0].Tag;

            pedido.Estado = 3;

            await Negocio.EditarPedido(pedido);
            this.ReloadOrderList();
        }
        private async void tsmiPedidoKO_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)lvOrders.SelectedItems[0].Tag;

            pedido.Estado = 4;

            await Negocio.EditarPedido(pedido);
            this.ReloadOrderList();
        }
        private async void tsmiEliminarPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)lvOrders.SelectedItems[0].Tag;
            if (MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el pedido?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                ) == DialogResult.Yes
            )
            {
                await Negocio.BorrarPedido(pedido.CodPedido);
                this.ReloadOrderList();
            }
        }
        private void PedidosFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // FUNCIONALIDADES
        private void cmsMenuOrder_Opening(object sender, CancelEventArgs e)
        {
            if (lvOrders.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
        }
        private void lvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count != 0)
            {
                tsmiEditarPedido.Enabled = true;
                tsmiCambiarEstadoPedido.Enabled = true;
                tsmiPedidoOK.Enabled = true;
                tsmiPedidoParcial.Enabled = true;
                tsmiPedidoKO.Enabled = true;
            }
            else
            {
                tsmiEditarPedido.Enabled = false;
                tsmiCambiarEstadoPedido.Enabled = false;
                tsmiPedidoOK.Enabled = false;
                tsmiPedidoParcial.Enabled = false;
                tsmiPedidoKO.Enabled = false;
            }
        }
        private void lvOrders_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void lvOrders_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Índice de la columna de estados
            int estadoColIndex = 3;

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

                    case "OK":
                        backColor = Color.LightGreen;
                        break;

                    case "Parcial":
                        backColor = Color.Orange;
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
                    e.Graphics.DrawString(e.SubItem.Text, lvOrders.Font, textBrush, e.Bounds);
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
