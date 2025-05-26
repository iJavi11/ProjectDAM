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

namespace albartohnosDesktop.CreateUpdateFRM
{
    public partial class RutaFRM : Form
    {
        private Ruta ruta;
        private List<EstadoRuta> estadosRuta;
        private List<Usuario> conductores;
        private List<Vehiculo> vehiculos;

        public RutaFRM()
        {
            InitializeComponent();
        }
        public RutaFRM(Ruta ruta, List<EstadoRuta> estadosRuta, List<Usuario> conductores, List<Vehiculo> vehiculos) : this()
        {
            this.estadosRuta = estadosRuta;
            this.conductores = conductores;
            this.vehiculos = vehiculos;
            // Rellenamos el ComboBox con los estados de la ruta
            cboEstadosRuta.DataSource = this.estadosRuta;
            cboEstadosRuta.DisplayMember = "Nombre";
            cboEstadosRuta.ValueMember = "Id";
            // Rellenamos el ComboBox con los conductores
            cboConductores.DataSource = this.conductores;
            cboConductores.DisplayMember = "Login";
            cboConductores.ValueMember = "Login";
            // Rellenamos el ComboBox con los vehículos
            cboVehiculos.DataSource = this.vehiculos;
            cboVehiculos.DisplayMember = "Matricula";
            cboVehiculos.ValueMember = "Matricula";

            this.ruta = ruta;

            if (!string.IsNullOrEmpty(this.ruta.CodRuta))
            {
                lblTitle.Text = "Editar Ruta";
                // Rellenar los campos con los datos de la ruta
                txtCodRuta.Text = this.ruta.CodRuta;
                txtCodRuta.ReadOnly = true; // Solo lectura en edición
                cboEstadosRuta.SelectedValue = this.ruta.Estado;
                cboEstadosRuta.Enabled = false;
                cboConductores.SelectedValue = this.ruta.Conductor;
                cboVehiculos.SelectedValue = this.ruta.Vehiculo;
                txtDescripcion.Text = this.ruta.Descripcion;
                dtpFPrevInicio.Value = this.ruta.FechaPrevInicio ?? DateTime.Now;
                dtpFPrevFin.Value = this.ruta.FechaPrevFin ?? DateTime.Now;
            }
            else
            {
                lblTitle.Text = "Crear Ruta";
                txtCodRuta.Text = "RUTA-";
                cboEstadosRuta.SelectedValue = this.ruta.Estado;
                cboEstadosRuta.Enabled = false;
                cboConductores.SelectedValue = -1;
                cboVehiculos.SelectedValue = -1;
                dtpFPrevInicio.Value = this.ruta.FechaPrevInicio ?? DateTime.Now;
                dtpFPrevFin.Value = this.ruta.FechaPrevFin ?? DateTime.Now;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtCodRuta.Text))
            {
                MessageBox.Show("El campo Código de Ruta es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtCodRuta.Focus();

                return false;
            }
            if (cboEstadosRuta.SelectedValue == null || cboEstadosRuta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboEstadosRuta.Focus();

                return false;
            }

            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //LO PRIMERO QUE HAREMOS SERÁ VALIDAR QUE LOS DATOS SON CORRECTOS
            if (!ValidarDatos())
            {
                //SI NO SE QUIERE SEGUIR SE USA EL RETURN.
                return; //SI LOS DATOS QUE DAMOS NO SON VÁLIDOS SE SALE DEL MÉTODO
            }

            // ALMACENAMOS LOS NUEVOS DATOS EN EL OBJETO RUTA
            this.ruta.CodRuta = txtCodRuta.Text;
            this.ruta.Estado = (int)cboEstadosRuta.SelectedValue;
            this.ruta.Conductor = cboConductores.SelectedValue.ToString();
            this.ruta.Vehiculo = cboVehiculos.SelectedValue.ToString();
            this.ruta.Descripcion = txtDescripcion.Text;
            this.ruta.FechaPrevInicio = dtpFPrevInicio.Value;
            this.ruta.FechaPrevFin = dtpFPrevFin.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
