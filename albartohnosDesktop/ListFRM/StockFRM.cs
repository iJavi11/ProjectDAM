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
    public partial class StockFRM : Form
    {
        private Usuario currentUser;
        // Datos que se cachearán al acceder a módulo de Stock
        private List<Producto> productos;
        private List<CentroParada> almacenes;
        // Datos que puede o no venir. Depende del origen del formulario
        private Producto producto = null;
        private CentroParada almacen = null;
        // Lista de Stock del Producto o Almacen
        private List<Stock> stock;

        public StockFRM()
        {
            InitializeComponent();

            this.FormClosed += StockFRM_FormClosed;
        }

        public StockFRM(Usuario usuario, Producto producto) : this()
        {
            currentUser = usuario;
            this.producto = producto;
            // Ponemos el valor de lblTitle correcto
            lblTitle.Text = $"Stock del Producto - {producto.Nombre}";
            // Inicializar la lista de Stock del Producto, indicando en que almacen se encuentra el producto y su cantidad
            ReloadProductStockList();
        }
        public StockFRM(Usuario usuario, CentroParada almacen) : this()
        {
            currentUser = usuario;
            this.almacen = almacen;
            // Ponemos el valor de lblTitle correcto
            lblTitle.Text = $"Stock del Almacen - {almacen.Nombre}";
            // Inicializar la lista de Stock del Almacen, indicando en que producto se encuentra el almacen y su cantidad
            ReloadWarehouseStockList();
        }

        private async void ReloadProductStockList()
        {
            almacenes = await Negocio.ObtenerAlmacenes();
            stock = await Negocio.ObtenerStockProducto(producto.Sku);

            // Limpiamos el ListView antes de añadir nada
            lvStock.Items.Clear();

            // Iteramos sobre la lista de vehículos y los añadimos al ListView
            foreach (var itemStock in stock)
            {
                CentroParada almacenAUX = almacenes.FirstOrDefault(a => a.Id == itemStock.IdAlmacen);

                ListViewItem item = new ListViewItem(itemStock.IdAlmacen);
                item.SubItems.Add(almacenAUX.Nombre);
                item.SubItems.Add(itemStock.Cantidad.ToString());

                item.Tag = itemStock;

                lvStock.Items.Add(item);
            }
        }
        private async void ReloadWarehouseStockList()
        {
            productos = await Negocio.ObtenerProductos();
            stock = await Negocio.ObtenerStockAlmacen(almacen.Id);

            // Limpiamos el ListView antes de añadir nada
            lvStock.Items.Clear();

            // Iteramos sobre la lista de vehículos y los añadimos al ListView
            foreach (var itemStock in stock)
            {
                Producto productoAUX = productos.FirstOrDefault(p => p.Sku == itemStock.SkuProducto);

                ListViewItem item = new ListViewItem(itemStock.SkuProducto);
                item.SubItems.Add(productoAUX.Nombre);
                item.SubItems.Add(itemStock.Cantidad.ToString());

                item.Tag = itemStock;

                lvStock.Items.Add(item);
            }
        }
        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (producto != null)
            {
                ReloadProductStockList();
            }
            else if (almacen != null)
            {
                ReloadWarehouseStockList();
            }
        }
        private async void btnCreateStock_Click(object sender, EventArgs e)
        {
            Stock itemStock = new Stock();
            

            InventarioFRM ventana;
            if (producto != null)
            {
                itemStock.SkuProducto = producto.Sku;

                ventana = new InventarioFRM(itemStock, producto, almacenes);
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    await Negocio.CrearStock(itemStock);
                    ReloadProductStockList();
                }
            }
            else if (almacen != null)
            {
                itemStock.IdAlmacen = almacen.Id;

                ventana = new InventarioFRM(itemStock, almacen, productos.FindAll(p => p.Activo == 1));
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    await Negocio.CrearStock(itemStock);
                    ReloadWarehouseStockList();
                }
            }
        }
        private async void tsmiEditStock_Click(object sender, EventArgs e)
        {
            Stock itemStock = (Stock)lvStock.SelectedItems[0].Tag;
            InventarioFRM ventana;
            if (producto != null)
            {
                ventana = new InventarioFRM(itemStock, producto, almacenes);
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    await Negocio.EditarStock(itemStock);
                    ReloadProductStockList();
                }
            }
            else if (almacen != null)
            {
                ventana = new InventarioFRM(itemStock, almacen, productos);
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    await Negocio.EditarStock(itemStock);
                    ReloadWarehouseStockList();
                }
            }
        }
        private async void tsmiEliminarStock_Click(object sender, EventArgs e)
        {
            Stock itemStock = (Stock)lvStock.SelectedItems[0].Tag;
            if (MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el Stock?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                ) == DialogResult.Yes
            )
            {
                await Negocio.BorrarStock(itemStock.IdAlmacen, itemStock.SkuProducto);
                // Actualizamos la lista de stock
                if (producto != null)
                {
                    ReloadProductStockList();
                }
                else if (almacen != null)
                {
                    ReloadWarehouseStockList();
                }
            }
        }
        private void StockFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // FUNCIONALIDADES
        private void cmsMenuStock_Opening(object sender, CancelEventArgs e)
        {
            if (lvStock.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
        }
        private void lvStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStock.SelectedItems.Count != 0)
            {
                tsmiEditStock.Enabled = true;
                // Permisos de usuario
                if (currentUser.Perfil != 1)
                {
                    tsmiEliminarStock.Enabled = false;
                }
                else
                {
                    tsmiEliminarStock.Enabled = true;
                }
            }
            else
            {
                tsmiEditStock.Enabled = false;
                tsmiEliminarStock.Enabled = false;
            }
        }
    }
}
