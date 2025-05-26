using albartohnosDesktop.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace albartohnosDesktop.CreateUpdateFRM
{
    public partial class InventarioFRM : Form
    {
        private Stock stock;
        // Datos que para los ComboBox
        private List<Producto> productos = new List<Producto>();
        private List<CentroParada> almacenes = new List<CentroParada>();

        public InventarioFRM()
        {
            InitializeComponent();
        }

        public InventarioFRM(Stock stock, Producto producto, List<CentroParada> almacenes) : this()
        {
            this.stock = stock;
            productos.Add(producto);
            this.almacenes = almacenes;

            // Rellenamos el ComboBox con los Almacenes
            cboAlmacen.DataSource = this.almacenes;
            cboAlmacen.DisplayMember = "Nombre";
            cboAlmacen.ValueMember = "Id";
            // Rellenamos el ComboBox con los Productos
            cboProducto.DataSource = this.productos;
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "Sku";

            if (!string.IsNullOrEmpty(this.stock.IdAlmacen))
            {
                lblTitle.Text = "Editar Stock de Almacen";
                cboAlmacen.SelectedValue = this.stock.IdAlmacen;
                cboAlmacen.Enabled = false; // Deshabilitar el comboBox de Almacen
                cboProducto.SelectedValue = this.stock.SkuProducto;
                cboProducto.Enabled = false; // Deshabilitar el comboBox de Producto
                txtCantidad.Text = this.stock.Cantidad.ToString();
            }
            else
            {
                lblTitle.Text = "Crear Stock de Almacen";
                cboAlmacen.SelectedIndex = -1;
                cboProducto.SelectedValue = this.stock.SkuProducto;
                cboProducto.Enabled = false; // Deshabilitar el comboBox de Producto
            }
        }
        public InventarioFRM(Stock stock, CentroParada almacen, List<Producto> productos) : this()
        {
            this.stock = stock;
            almacenes.Add(almacen);
            this.productos = productos;

            // Rellenamos el ComboBox con los Almacenes
            cboAlmacen.DataSource = this.almacenes;
            cboAlmacen.DisplayMember = "Nombre";
            cboAlmacen.ValueMember = "Id";
            // Rellenamos el ComboBox con los Productos
            cboProducto.DataSource = this.productos;
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "Sku";

            if (!string.IsNullOrEmpty(this.stock.SkuProducto))
            {
                lblTitle.Text = "Editar Stock de Producto";
                cboAlmacen.SelectedValue = this.stock.IdAlmacen;
                cboAlmacen.Enabled = false; // Deshabilitar el comboBox de Almacen
                cboProducto.SelectedValue = this.stock.SkuProducto;
                cboProducto.Enabled = false; // Deshabilitar el comboBox de Producto
                txtCantidad.Text = this.stock.Cantidad.ToString();
            }
            else
            {
                lblTitle.Text = "Crear Stock de Producto";
                cboAlmacen.SelectedValue = this.stock.IdAlmacen;
                cboAlmacen.Enabled = false; // Deshabilitar el comboBox de Almacen
                cboProducto.SelectedIndex = -1;
            }
        }
        private bool ValidarDatos()
        {
            // Validar que los campos no estén vacíos
            if (cboProducto.SelectedValue == null || cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Almacen", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboAlmacen.Focus();

                return false;
            }
            if (cboAlmacen.SelectedValue == null || cboAlmacen.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Almacen", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboAlmacen.Focus();

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

            return true; // Si todo es correcto, devolvemos true
        }
        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            //LO PRIMERO QUE HAREMOS SERÁ VALIDAR QUE LOS DATOS SON CORRECTOS
            if (!ValidarDatos())
            {
                //SI NO SE QUIERE SEGUIR SE USA EL RETURN.
                return; //SI LOS DATOS QUE DAMOS NO SON VÁLIDOS SE SALE DEL MÉTODO
            }

            // ALMACENAMOS LOS NUEVOS DATOS EN EL OBJETO VEHICULO
            this.stock.IdAlmacen = (string)cboAlmacen.SelectedValue;
            this.stock.SkuProducto = (string)cboProducto.SelectedValue;
            this.stock.Cantidad = int.Parse(txtCantidad.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
