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
    public partial class ParadaFRM : Form
    {
        private Parada parada;
        private List<EstadoParada> estadosParada;
        private List<CentroParada> centrosParada;

        public ParadaFRM()
        {
            InitializeComponent();
        }
        public ParadaFRM(Parada parada, List<EstadoParada> estadosParada, List<CentroParada> centrosParada) : this()
        {
            this.estadosParada = estadosParada;
            this.centrosParada = centrosParada;
            // Rellenamos el ComboBox con los estados de la parada
            cboEstadosParada.DataSource = this.estadosParada;
            cboEstadosParada.DisplayMember = "Nombre";
            cboEstadosParada.ValueMember = "Id";
            // Rellenamos el ComboBox con los Centros de Parada
            cboCentrosParada.DataSource = this.centrosParada;
            cboCentrosParada.DisplayMember = "Nombre";
            cboCentrosParada.ValueMember = "Id";

            this.parada = parada;

            // Rellenamos los campos que van a estar Inactivos si o si
            txtCodRuta.Text = this.parada.Ruta;
            cboEstadosParada.SelectedValue = this.parada.Estado;
            txtOrden.Text = this.parada.Orden.ToString();

            if (this.parada.Id != 0)
            {
                lblTitle.Text = "Editar Parada";
                // Rellenar los campos con los datos de la parada
                cboCentrosParada.SelectedValue = this.parada.CentroParada;
                cboCentrosParada.Enabled = false;
                dtpFPrev.Value = this.parada.FechaPrev ?? DateTime.Now;
            }
            else
            {
                lblTitle.Text = "Crear Parada";
                // Rellenar los campos con los datos de la parada
                cboCentrosParada.SelectedValue = -1;
                dtpFPrev.Value = this.parada.FechaPrev ?? DateTime.Now;
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
            if (cboEstadosParada.SelectedValue == null || cboEstadosParada.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboEstadosParada.Focus();

                return false;
            }
            if (cboCentrosParada.SelectedValue == null || cboCentrosParada.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Centro de Parada.", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboCentrosParada.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtOrden.Text))
            {
                MessageBox.Show("El campo Orden es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtOrden.Focus();

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
            this.parada.Ruta = txtCodRuta.Text;
            this.parada.CentroParada = cboCentrosParada.SelectedValue.ToString();
            this.parada.Orden = int.Parse(txtOrden.Text);
            this.parada.Estado = (int)cboEstadosParada.SelectedValue;
            this.parada.FechaPrev = dtpFPrev.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
