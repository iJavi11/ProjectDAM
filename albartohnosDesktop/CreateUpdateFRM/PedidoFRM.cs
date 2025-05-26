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
    public partial class PedidoFRM : Form
    {
        private Pedido pedido;
        private List<EstadoPedido> estadosPedido;
        private List<TipoPedido> tiposPedido;
        private List<Producto> productos;

        public PedidoFRM()
        {
            InitializeComponent();
        }
        public PedidoFRM(Pedido pedido, List<EstadoPedido> estadosPedido, List<TipoPedido> tiposPedido, List<Producto> productos) : this()
        {
            this.estadosPedido = estadosPedido;
            this.tiposPedido = tiposPedido;
            this.productos = productos;
            // Rellenamos el ComboBox con los productos
            cboProductos.DataSource = this.productos;
            cboProductos.DisplayMember = "Nombre";
            cboProductos.ValueMember = "Sku";
            // Rellenamos el ComboBox con los tipos de pedido
            cboTiposPedido.DataSource = this.tiposPedido;
            cboTiposPedido.DisplayMember = "Nombre";
            cboTiposPedido.ValueMember = "Id";
            // Rellenamos el ComboBox con los estados de pedido
            cboEstadosPedido.DataSource = this.estadosPedido;
            cboEstadosPedido.DisplayMember = "Nombre";
            cboEstadosPedido.ValueMember = "Id";

            this.pedido = pedido;

            // Rellenamos los campos que van a estar Inactivos si o si
            cboEstadosPedido.SelectedValue = this.pedido.Estado;

            if (!string.IsNullOrEmpty(pedido.CodPedido))
            {
                lblTitle.Text = "Editar Pedido";
                // Rellenar los campos con los datos del pedido
                txtCodPedido.Text = this.pedido.CodPedido;
                txtCodPedido.Enabled = false; // Deshabilitamos el campo de código de pedido
                cboProductos.SelectedValue = this.pedido.SkuProducto;
                cboTiposPedido.SelectedValue = this.pedido.Tipo;
                txtCantidad.Text = this.pedido.Cantidad.ToString();
                txtPrecio.Text = this.pedido.Precio.ToString("F2");
            }
            else
            {
                lblTitle.Text = "Crear Pedido";
                
                cboProductos.SelectedValue = -1;
                cboTiposPedido.SelectedValue = -1;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtCodPedido.Text))
            {
                MessageBox.Show("El campo Código de Pedido es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtCodPedido.Focus();

                return false;
            }
            if (cboProductos.SelectedValue == null || cboProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboProductos.Focus();

                return false;
            }
            if (cboTiposPedido.SelectedValue == null || cboTiposPedido.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de Pedido.", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboTiposPedido.Focus();

                return false;
            }
            if (cboEstadosPedido.SelectedValue == null || cboEstadosPedido.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboEstadosPedido.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("El campo Cantidad es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtCantidad.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("El campo Precio es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtPrecio.Focus();

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

            // ALMACENAMOS LOS NUEVOS DATOS EN EL OBJETO PEDIDO
            pedido.CodPedido = txtCodPedido.Text;
            pedido.SkuProducto = cboProductos.SelectedValue.ToString();
            pedido.Tipo = (int)cboTiposPedido.SelectedValue;
            pedido.Estado = (int)cboEstadosPedido.SelectedValue;
            pedido.Cantidad = int.Parse(txtCantidad.Text);
            pedido.Precio = decimal.Parse(txtPrecio.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
