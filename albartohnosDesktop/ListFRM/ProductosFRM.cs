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
    public partial class ProductosFRM : Form
    {
        private Usuario currentUser;
        private List<Producto> productos;

        public ProductosFRM(Usuario usuario)
        {
            InitializeComponent();

            currentUser = usuario;

            // Inicializar la lista de vehículos
            ReloadProductList();

            // Permisos de usuario
            if (currentUser.Perfil != 1)
            {
                tsmiEliminarProducto.Enabled = false; // Opción de Eliminar Producto
            }

            this.FormClosed += ProductosFRM_FormClosed;
        }

        private async void ReloadProductList()
        {
            productos = await Negocio.ObtenerProductos();

            // Limpiamos el ListView antes de añadir nada
            lvProducts.Items.Clear();

            // Iteramos sobre la lista de vehículos y los añadimos al ListView
            foreach (var producto in productos)
            {
                ListViewItem item = new ListViewItem(producto.Sku);
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Activo.ToString());
                item.SubItems.Add(producto.Descripcion);

                item.Tag = producto;

                lvProducts.Items.Add(item);
            }
        }
        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            ReloadProductList();
        }
        private async void btnCreateProduct_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoFRM ventana = new ProductoFRM(producto);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.CrearProducto(producto);
                this.ReloadProductList();
            }
        }
        private void tsmiVerStockProducto_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)lvProducts.SelectedItems[0].Tag;
            // Crear una instancia del formulario StockFRM
            var stockForm = new StockFRM(currentUser, producto);

            // Mostrar el formulario como una ventana modal
            stockForm.ShowDialog();
        }
        private async void tsmiEditarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)lvProducts.SelectedItems[0].Tag;
            ProductoFRM ventana = new ProductoFRM(producto);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.EditarProducto(producto);
                this.ReloadProductList();
            }
        }
        private async void tsmiActivarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)lvProducts.SelectedItems[0].Tag;

            producto.Activo = 1;

            await Negocio.EditarProducto(producto);
            this.ReloadProductList();
        }
        private async void tsmiDesactivarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)lvProducts.SelectedItems[0].Tag;

            producto.Activo = 0;

            await Negocio.EditarProducto(producto);
            this.ReloadProductList();
        }
        private async void tsmiEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)lvProducts.SelectedItems[0].Tag;
            if (MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el producto {producto.Sku}?\n" +
                    $"Ten en cuenta que solo se puede eliminar productos que no están vinculados a ningún pedido u stock.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                ) == DialogResult.Yes
            )
            {
                await Negocio.BorrarProducto(producto.Sku);
                this.ReloadProductList();
            }
        }
        private void ProductosFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // FUNCIONALIDADES
        private void cmsMenuProduct_Opening(object sender, CancelEventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                Producto producto = (Producto)lvProducts.SelectedItems[0].Tag;
                tsmiDesactivarProducto.Visible = producto.Activo == 1;
                tsmiActivarProducto.Visible = producto.Activo == 0;
            }
        }
        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count != 0)
            {
                tsmiVerStockProducto.Enabled = true;
                tsmiEditarProducto.Enabled = true;
                tsmiActivarProducto.Enabled = true;
                tsmiDesactivarProducto.Enabled = true;
                tsmiEliminarProducto.Enabled = true;
            }
            else
            {
                tsmiVerStockProducto.Enabled = true;
                tsmiEditarProducto.Enabled = false;
                tsmiActivarProducto.Enabled = false;
                tsmiDesactivarProducto.Enabled = false;
                tsmiEliminarProducto.Enabled = false;
            }
        }
    }
}
