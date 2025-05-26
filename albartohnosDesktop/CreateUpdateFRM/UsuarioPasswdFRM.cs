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
    public partial class UsuarioPasswdFRM : Form
    {
        private Usuario usuario;

        public UsuarioPasswdFRM()
        {
            InitializeComponent();
        }
        public UsuarioPasswdFRM(Usuario usuario) : this()
        {
            this.usuario = usuario;
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNewPasswd1.Text))
            {
                MessageBox.Show("El campo 'Introduzca la nueva Contraseña' es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtNewPasswd1.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(txtNewPasswd2.Text))
            {
                MessageBox.Show("El campo 'Escribe de nuevo la Contraseña' es Obligatorio", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtNewPasswd2.Focus();

                return false;
            }
            if (!txtNewPasswd1.Text.Equals(txtNewPasswd2.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden", "Atención",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //MARCAMOS EL CAMPO QUE DA EL ERROR
                this.txtNewPasswd1.Focus();
                this.txtNewPasswd2.Focus();

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

            // ALMACENAMOS LOS NUEVOS DATOS EN EL OBJETO USUARIO
            this.usuario.Password = LoginFRM.Encriptador(txtNewPasswd1.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
