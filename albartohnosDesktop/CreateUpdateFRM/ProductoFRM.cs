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
    public partial class ProductoFRM : Form
    {
        private Producto producto;
        public ProductoFRM()
        {
            InitializeComponent();
        }

        public ProductoFRM(Producto producto) : this()
        {
            this.producto = producto;

            if (!string.IsNullOrEmpty(this.producto.Sku))
            {
                lblTitle.Text = "Editar Producto";
                // Rellenar los campos con los datos del producto
                txtSKU.Text = this.producto.Sku;
                txtSKU.ReadOnly = true; // Solo lectura en edición

                txtNombre.Text = this.producto.Nombre;
                txtDescripcion.Text = this.producto.Descripcion;
                chkActivo.Checked = this.producto.Activo == 1;
            }
            else
            {
                lblTitle.Text = "Crear Producto";
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.txtSKU.Text))
            {
                MessageBox.Show("El campo SKU es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtSKU.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtNombre.Focus();

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

            // ALMACENAMOS LOS NUEVOS DATOS EN EL OBJETO VEHICULO
            this.producto.Sku = this.txtSKU.Text;
            this.producto.Nombre = this.txtNombre.Text;
            this.producto.Descripcion = this.txtDescripcion.Text;
            this.producto.Activo = (sbyte)(this.chkActivo.Checked ? 1 : 0);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
