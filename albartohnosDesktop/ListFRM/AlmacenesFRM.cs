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
        private List<CentroParada> almacenes;

        public AlmacenesFRM(Usuario usuario)
        {
            InitializeComponent();

            currentUser = usuario;

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
                ListViewItem item = new ListViewItem(almacen.Nombre);
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
        private void AlmacenesFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
