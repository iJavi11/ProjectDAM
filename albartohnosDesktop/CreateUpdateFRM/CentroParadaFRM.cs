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
using System.Windows.Forms.VisualStyles;

namespace albartohnosDesktop.CreateUpdateFRM
{
    public partial class CentroParadaFRM : Form
    {
        private CentroParada centroParada;
        private List<TipoCentro> tiposCentro;

        public CentroParadaFRM()
        {
            InitializeComponent();
        }
        public CentroParadaFRM(CentroParada centroParada, List<TipoCentro> tiposCentro, bool isAlmacen) : this()
        {
            this.tiposCentro = tiposCentro;
            // Rellenamos el ComboBox con los tipos de centro
            cboTipoCentro.DataSource = this.tiposCentro;
            cboTipoCentro.DisplayMember = "Nombre";
            cboTipoCentro.ValueMember = "Id";

            this.centroParada = centroParada;

            if (!string.IsNullOrEmpty(this.centroParada.Id))
            {
                lblTitle.Text = isAlmacen ? "Editar Almacen" : "Editar Centro de Parada";
                // Rellenar los campos con los datos del vehículo
                txtCodInterno.Text = this.centroParada.Id;
                txtCodInterno.ReadOnly = true; // Solo lectura en edición

                txtNombre.Text = this.centroParada.Nombre;
                txtCCAA.Text = this.centroParada.Ccaa;
                txtLocalidad.Text = this.centroParada.Localidad;
                txtDireccion.Text = this.centroParada.Direccion;
                txtTLF.Text = this.centroParada.Tlf;
                txtEmail.Text = this.centroParada.Email;
                cboTipoCentro.SelectedValue = this.centroParada.TipoCentro;

                // Deshabilitar el comboBox en caso de que sea un almacen
                cboTipoCentro.Enabled = isAlmacen ? false : true;
            }
            else
            {
                if (isAlmacen)
                {
                    lblTitle.Text = "Crear Almacen";
                    cboTipoCentro.SelectedValue = this.tiposCentro.FirstOrDefault(t => t.Nombre.ToLower().Equals("Almacén".ToLower())).Id;
                    cboTipoCentro.Enabled = isAlmacen ? false : true;
                }
                else
                {
                    lblTitle.Text = "Crear Centro de Parada";
                    cboTipoCentro.SelectedIndex = -1;
                }
            }
        }
        private bool ValidarDatos()
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtCodInterno.Text))
            {
                MessageBox.Show("El campo Código Interno es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtCodInterno.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtNombre.Focus();

                return false;
            }
            if (cboTipoCentro.SelectedValue == null || cboTipoCentro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de centro.", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboTipoCentro.Focus();

                return false;
            }

            return true; // Si todo es correcto, devolvemos true
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //LO PRIMERO QUE HAREMOS SERÁ VALIDAR QUE LOS DATOS SON CORRECTOS
            if (!ValidarDatos())
            {
                //SI NO SE QUIERE SEGUIR SE USA EL RETURN.
                return; //SI LOS DATOS QUE DAMOS NO SON VÁLIDOS SE SALE DEL MÉTODO
            }

            // ALMACENAMOS LOS NUEVOS DATOS EN EL OBJETO VEHICULO
            this.centroParada.Id = txtCodInterno.Text;
            this.centroParada.Nombre = txtNombre.Text;
            this.centroParada.TipoCentro = (int)cboTipoCentro.SelectedValue;
            this.centroParada.Tlf = txtTLF.Text;
            this.centroParada.Email = txtEmail.Text;
            this.centroParada.Ccaa = txtCCAA.Text;
            this.centroParada.Localidad = txtLocalidad.Text;
            this.centroParada.Direccion = txtDireccion.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
