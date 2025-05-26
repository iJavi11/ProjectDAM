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
    public partial class AlmacenesFRM : Form
    {
        private Usuario currentUser;
        private List<TipoCentro> tiposCentro;
        private List<CentroParada> almacenes;

        public AlmacenesFRM(Usuario usuario, List<TipoCentro> tiposCentro)
        {
            InitializeComponent();

            currentUser = usuario;
            this.tiposCentro = tiposCentro;

            // Inicializar la lista de almacenes
            ReloadWarehouseList();

            this.FormClosed += AlmacenesFRM_FormClosed;
        }

        private async void ReloadWarehouseList()
        {
            almacenes = await Negocio.ObtenerAlmacenes();

            // Limpiamos el ListView antes de añadir nada
            lvWh.Items.Clear();

            // Iteramos sobre la lista de vehículos y los añadimos al ListView
            foreach (var almacen in almacenes)
            {
                ListViewItem item = new ListViewItem(almacen.Id);
                item.SubItems.Add(almacen.Nombre);
                item.SubItems.Add(almacen.Tlf);
                item.SubItems.Add(almacen.Email);
                item.SubItems.Add(almacen.Ccaa);
                item.SubItems.Add(almacen.Localidad);
                item.SubItems.Add(almacen.Direccion);

                item.Tag = almacen;

                lvWh.Items.Add(item);
            }
        }
        private void btnUpdateWh_Click(object sender, EventArgs e)
        {
            ReloadWarehouseList();
        }
        private async void btnCreateWh_Click(object sender, EventArgs e)
        {
            CentroParada almacen = new CentroParada();
            CentroParadaFRM ventana = new CentroParadaFRM(almacen, tiposCentro, true);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.CrearCentroParada(almacen);
                this.ReloadWarehouseList();
            }
        }
        private async void tsmiEditWh_Click(object sender, EventArgs e)
        {
            CentroParada almacen = (CentroParada)lvWh.SelectedItems[0].Tag;
            CentroParadaFRM ventana = new CentroParadaFRM(almacen, tiposCentro, true);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.EditarCentroParada(almacen);
                this.ReloadWarehouseList();
            }
        }
        private void tsmiWhStock_Click(object sender, EventArgs e)
        {
            CentroParada almacen = (CentroParada)lvWh.SelectedItems[0].Tag;
            // Crear una instancia del formulario StockFRM
            var stockForm = new StockFRM(currentUser, almacen);

            // Mostrar el formulario como una ventana modal
            stockForm.ShowDialog();
        }
        private async void tsmiDeleteWh_Click(object sender, EventArgs e)
        {
            CentroParada almacen = (CentroParada)lvWh.SelectedItems[0].Tag;
            if (MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el almacén?\n" +
                    $"Ten en cuenta que solo se puede eliminar almacenes que no están vinculados a ninguna ruta y no poseen stock.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                ) == DialogResult.Yes
            )
            {
                await Negocio.BorrarCentroParada(almacen.Id);
                this.ReloadWarehouseList();
            }
        }
        private void AlmacenesFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // FUNCIONALIDADES
        private void cmsMenuWh_Opening(object sender, CancelEventArgs e)
        {
            if (lvWh.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
        }
        private void lvWh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWh.SelectedItems.Count != 0)
            {
                tsmiEditWh.Enabled = true;
                tsmiDeleteWh.Enabled = true;
            }
            else
            {
                tsmiEditWh.Enabled = false;
                tsmiDeleteWh.Enabled = false;
            }
        }
    }
}
