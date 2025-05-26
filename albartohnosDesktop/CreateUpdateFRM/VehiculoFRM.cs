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
    public partial class VehiculoFRM : Form
    {
        private Vehiculo vehiculo;
        public VehiculoFRM()
        {
            InitializeComponent();
        }

        public VehiculoFRM(Vehiculo vehiculo) : this()
        {
            this.vehiculo = vehiculo;

            if (!string.IsNullOrEmpty(this.vehiculo.Matricula))
            {
                lblTitle.Text = "Editar Vehículo";
                // Rellenar los campos con los datos del vehículo
                txtMatricula.Text = this.vehiculo.Matricula;
                txtMatricula.ReadOnly = true; // Solo lectura en edición

                txtMarca.Text = this.vehiculo.Marca;
                txtModelo.Text = this.vehiculo.Modelo;
                txtDescripcion.Text = this.vehiculo.Descripcion;
                txtCapacidad.Text = this.vehiculo.Capacidad.ToString();
                dtpFAlta.Value = this.vehiculo.FechaAlta ?? DateTime.Now;
                chkActivo.Checked = this.vehiculo.Activo == 1;

                // Ocultar Fecha de Baja si el vehículo está activo
                if (chkActivo.Checked)
                {
                    dtpFBaja.Visible = false;
                    lblFBaja.Visible = false;
                }
                else
                {
                    dtpFBaja.Visible = true;
                    lblFBaja.Visible = true;
                    // Rellenar la fecha de baja
                    dtpFBaja.Value = this.vehiculo.FechaBaja ?? DateTime.Now;
                }
            }
            else
            {
                lblTitle.Text = "Crear Vehículo";
                // Validación básica para mostrar o no la Fecha de Baja
                if (chkActivo.Checked)
                {
                    dtpFBaja.Visible = false;
                    lblFBaja.Visible = false;
                }
                else
                {
                    dtpFBaja.Visible = true;
                    lblFBaja.Visible = true;
                    // Rellenar la fecha de baja
                    dtpFBaja.Value = this.vehiculo.FechaBaja ?? DateTime.Now;
                }
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.txtMatricula.Text))
            {
                MessageBox.Show("El campo Matrícula es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtMatricula.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(this.txtMarca.Text))
            {
                MessageBox.Show("El campo Marca es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtMarca.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(this.txtModelo.Text))
            {
                MessageBox.Show("El campo Modelo es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtModelo.Focus();

                return false;
            }

            return true;
        }
        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            // Ocultar Fecha de Baja si el vehículo está activo
            if (chkActivo.Checked)
            {
                dtpFBaja.Visible = false;
                lblFBaja.Visible = false;
            }
            else
            {
                dtpFBaja.Visible = true;
                lblFBaja.Visible = true;
                // Rellenar la fecha de baja
                dtpFBaja.Value = DateTime.Now;
            }
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
            this.vehiculo.Matricula = this.txtMatricula.Text;
            this.vehiculo.Marca = this.txtMarca.Text;
            this.vehiculo.Modelo = this.txtModelo.Text;
            this.vehiculo.Descripcion = this.txtDescripcion.Text;
            this.vehiculo.Capacidad = string.IsNullOrEmpty(this.txtCapacidad.Text) ? (decimal?)null : decimal.Parse(this.txtCapacidad.Text);
            this.vehiculo.FechaAlta = this.dtpFAlta.Value;
            this.vehiculo.FechaBaja = this.chkActivo.Checked ? null : (DateTime?)this.dtpFBaja.Value;
            this.vehiculo.Activo = (sbyte)(this.chkActivo.Checked ? 1 : 0);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
