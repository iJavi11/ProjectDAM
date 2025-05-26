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
    public partial class VehiculosFRM : Form
    {
        private Usuario currentUser;
        private List<Vehiculo> vehiculos;

        public VehiculosFRM(Usuario usuario)
        {
            InitializeComponent();

            currentUser = usuario;

            // Inicializar la lista de vehículos
            ReloadVehicleList();

            // Permisos de usuario
            if (currentUser.Perfil != 1)
            {
                tsmiEliminarVehiculo.Enabled = false; // Opción de Eliminar Vehículo
            }

            this.FormClosed += VehiculosFRM_FormClosed;
        }

        private async void ReloadVehicleList()
        {
            vehiculos = await Negocio.ObtenerVehiculos();

            // Limpiamos el ListView antes de añadir nada
            lvVehicles.Items.Clear();

            // Iteramos sobre la lista de vehículos y los añadimos al ListView
            foreach (var vehiculo in vehiculos)
            {
                ListViewItem item = new ListViewItem(vehiculo.Matricula);
                item.SubItems.Add(vehiculo.Marca);
                item.SubItems.Add(vehiculo.Modelo);
                item.SubItems.Add(vehiculo.Descripcion);
                item.SubItems.Add(vehiculo.Capacidad.ToString());
                item.SubItems.Add(vehiculo.Activo.ToString());
                item.SubItems.Add(vehiculo.FechaAlta.ToString());
                item.SubItems.Add(vehiculo.FechaBaja.ToString());

                item.Tag = vehiculo;

                lvVehicles.Items.Add(item);
            }
        }
        private void btnUpdateVehicles_MouseClick(object sender, MouseEventArgs e)
        {
            ReloadVehicleList();
        }
        private async void btnCreateVehicle_MouseClick(object sender, MouseEventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            VehiculoFRM ventana = new VehiculoFRM(vehiculo);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.CrearVehiculo(vehiculo);
                this.ReloadVehicleList();
            }
        }
        private async void tsmiEditarVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = (Vehiculo)lvVehicles.SelectedItems[0].Tag;
            VehiculoFRM ventana = new VehiculoFRM(vehiculo);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.EditarVehiculo(vehiculo);
                this.ReloadVehicleList();
            }
        }
        private async void tsmiActivarVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = (Vehiculo)lvVehicles.SelectedItems[0].Tag;

            vehiculo.Activo = 1;
            vehiculo.FechaBaja = null;

            await Negocio.EditarVehiculo(vehiculo);
            this.ReloadVehicleList();
        }
        private async void tsmiDesactivarVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = (Vehiculo)lvVehicles.SelectedItems[0].Tag;

            vehiculo.Activo = 0;
            vehiculo.FechaBaja = DateTime.Now;

            await Negocio.EditarVehiculo(vehiculo);
            this.ReloadVehicleList();
        }
        private async void tsmiEliminarVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = (Vehiculo)lvVehicles.SelectedItems[0].Tag;
            if (MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el vehículo {vehiculo.Matricula}?\n" +
                    $"Ten en cuenta que solo se puede eliminar vehículo que no están vinculados a ninguna ruta.",
                    "Confirmar eliminación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                ) == DialogResult.Yes
            )
            {
                await Negocio.BorrarVehiculo(vehiculo.Matricula);
                this.ReloadVehicleList();
            }
        }
        private void VehiculosFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // FUNCIONALIDADES
        private void cmsMenuVehicle_Opening(object sender, CancelEventArgs e)
        {
            if (lvVehicles.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                Vehiculo vehiculo = (Vehiculo)lvVehicles.SelectedItems[0].Tag;
                tsmiDesactivarVehiculo.Visible = vehiculo.Activo == 1;
                tsmiActivarVehiculo.Visible = vehiculo.Activo == 0;
            }
        }
        private void lvVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVehicles.SelectedItems.Count != 0)
            {
                tsmiEditarVehiculo.Enabled = true;
                tsmiActivarVehiculo.Enabled = true;
                tsmiDesactivarVehiculo.Enabled = true;
                tsmiEliminarVehiculo.Enabled = true;
            }
            else
            {
                tsmiEditarVehiculo.Enabled = false;
                tsmiActivarVehiculo.Enabled = false;
                tsmiDesactivarVehiculo.Enabled = false;
                tsmiEliminarVehiculo.Enabled = false;
            }
        }
    }
}
