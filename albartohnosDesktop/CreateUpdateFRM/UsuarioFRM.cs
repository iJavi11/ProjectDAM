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
    public partial class UsuarioFRM : Form
    {
        private Usuario usuario;
        private List<Perfil> perfiles;

        public UsuarioFRM()
        {
            InitializeComponent();
        }
        public UsuarioFRM(Usuario usuario, List<Perfil> perfiles) : this()
        {
            this.perfiles = perfiles;
            // Rellenamos el ComboBox con los perfiles
            cboPerfiles.DataSource = this.perfiles;
            cboPerfiles.DisplayMember = "Nombre";
            cboPerfiles.ValueMember = "Id";

            this.usuario = usuario;

            if (!string.IsNullOrEmpty(this.usuario.Login))
            {
                lblTitle.Text = "Editar Usuario";
                // Rellenar los campos con los datos del usuario
                txtLogin.Text = this.usuario.Login;
                txtLogin.ReadOnly = true;  
                txtPasswd.Text = this.usuario.Password;
                lblPasswd.Visible = false; // Ocultar el label de contraseña en edición
                txtPasswd.Visible = false; // Ocultar el campo de contraseña en edición
                cboPerfiles.SelectedValue = this.usuario.Perfil;
                txtNombre.Text = this.usuario.Nombre;
                txtApellidos.Text = this.usuario.Apellidos;
                txtDni.Text = this.usuario.Dni;
                txtNss.Text = this.usuario.Nss;
                txtTLF.Text = this.usuario.Tlf;
                txtEmail.Text = this.usuario.Email;
                txtCCAA.Text = this.usuario.Ccaa;
                txtLocalidad.Text = this.usuario.Localidad;
                txtDireccion.Text = this.usuario.Direccion;
                dtpFAlta.Value = this.usuario.FechaAlta ?? DateTime.Now;
                dtpFBaja.Value = this.usuario.FechaBaja ?? DateTime.Now;
                chkActivo.Checked = this.usuario.Activo == 1;

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
                    dtpFBaja.Value = this.usuario.FechaBaja ?? DateTime.Now;
                }
            }
            else
            {
                lblTitle.Text = "Crear Usuario";
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
                    dtpFBaja.Value = this.usuario.FechaBaja ?? DateTime.Now;
                }
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("El campo Login es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtLogin.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtPasswd.Text))
            {
                MessageBox.Show("El campo Contraseña es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtPasswd.Focus();

                return false;
            }
            if (cboPerfiles.SelectedValue == null || cboPerfiles.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un perfil.", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.cboPerfiles.Focus();

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
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("El campo Apellidos es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtApellidos.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("El campo DNI es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtDni.Focus();

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

            // ALMACENAMOS LOS NUEVOS DATOS EN EL OBJETO USUARIO
            this.usuario.Login = txtLogin.Text;
            this.usuario.Password = lblPasswd.Visible ? LoginFRM.Encriptador(txtPasswd.Text) : txtPasswd.Text;
            this.usuario.Perfil = (int)cboPerfiles.SelectedValue;
            this.usuario.Nombre = txtNombre.Text;
            this.usuario.Apellidos = txtApellidos.Text;
            this.usuario.Dni = txtDni.Text;
            this.usuario.Nss = txtNss.Text;
            this.usuario.Tlf = txtTLF.Text;
            this.usuario.Email = txtEmail.Text;
            this.usuario.Ccaa = txtCCAA.Text;
            this.usuario.Localidad = txtLocalidad.Text;
            this.usuario.Direccion = txtDireccion.Text;
            this.usuario.FechaAlta = dtpFAlta.Value;
            this.usuario.FechaBaja = this.chkActivo.Checked ? null : (DateTime?)this.dtpFBaja.Value;
            this.usuario.Activo = (sbyte)(this.chkActivo.Checked ? 1 : 0);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
