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
    public partial class UsuariosFRM : Form
    {
        private Usuario currentUser;
        private List<Perfil> perfiles;
        private List<Usuario> usuarios;

        public UsuariosFRM(Usuario usuario, List<Perfil> perfiles)
        {
            InitializeComponent();

            currentUser = usuario;
            this.perfiles = perfiles;

            // Inicializar la lista de almacenes
            ReloadUserList();

            this.FormClosed += UsuariosFRM_FormClosed;
        }

        private async void ReloadUserList()
        {
            usuarios = await Negocio.ObtenerUsuarios();

            // Limpiamos el ListView antes de añadir nada
            lvUsers.Items.Clear();

            // Iteramos sobre la lista de vehículos y los añadimos al ListView
            foreach (var usuario in usuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Login);
                item.SubItems.Add(perfiles.FirstOrDefault(p => p.Id == usuario.Perfil)?.Nombre ?? "-");
                item.SubItems.Add(usuario.Nombre);
                item.SubItems.Add(usuario.Apellidos);
                item.SubItems.Add(usuario.Dni);
                item.SubItems.Add(usuario.Nss);
                item.SubItems.Add(usuario.Activo.ToString());
                item.SubItems.Add(usuario.Tlf);
                item.SubItems.Add(usuario.Email);
                item.SubItems.Add(usuario.Ccaa);
                item.SubItems.Add(usuario.Localidad);
                item.SubItems.Add(usuario.Direccion);
                item.SubItems.Add(usuario.FechaAlta.ToString());
                item.SubItems.Add(usuario.FechaBaja.ToString());

                item.Tag = usuario;

                lvUsers.Items.Add(item);
            }
        }
        private async void btnCreateUser_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioFRM ventana = new UsuarioFRM(usuario, perfiles);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.CrearUsuario(usuario);
                this.ReloadUserList();
            }
        }
        private async void tsmiEditarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)lvUsers.SelectedItems[0].Tag;
            UsuarioFRM ventana = new UsuarioFRM(usuario, perfiles);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.EditarUsuario(usuario);
                this.ReloadUserList();
            }
        }
        private async void tsmiCambiarPass_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)lvUsers.SelectedItems[0].Tag;
            UsuarioPasswdFRM ventana = new UsuarioPasswdFRM(usuario);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                await Negocio.EditarUsuario(usuario);
                this.ReloadUserList();
            }
        }
        private async void tsmiActivarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)lvUsers.SelectedItems[0].Tag;

            usuario.Activo = 1;
            usuario.FechaBaja = null;

            await Negocio.EditarUsuario(usuario);
            this.ReloadUserList();
        }
        private async void tsmiDesactivarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)lvUsers.SelectedItems[0].Tag;

            usuario.Activo = 0;
            usuario.FechaBaja = DateTime.Now;

            await Negocio.EditarUsuario(usuario);
            this.ReloadUserList();
        }
        private async void tsmiEliminarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)lvUsers.SelectedItems[0].Tag;
            if (MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el usuario - {usuario.Login}?\n" +
                    $"Ten en cuenta que solo se puede eliminar usuarios que no están vinculados a ninguna ruta",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                ) == DialogResult.Yes
            )
            {
                await Negocio.BorrarUsuario(usuario.Login);
                this.ReloadUserList();
            }
        }
        private void UsuariosFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // FUNCIONALIDADES
        private void cmsMenuUser_Opening(object sender, CancelEventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
        }
        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count != 0)
            {
                tsmiEditarUsuario.Enabled = true;
                tsmiCambiarPass.Enabled = true;
                tsmiActivarUsuario.Enabled = true;
                tsmiDesactivarUsuario.Enabled = true;
                tsmiEliminarUsuario.Enabled = true;
            }
            else
            {
                tsmiEditarUsuario.Enabled = false;
                tsmiCambiarPass.Enabled = false;
                tsmiActivarUsuario.Enabled = false;
                tsmiDesactivarUsuario.Enabled = false;
                tsmiEliminarUsuario.Enabled = false;
            }
        }
    }
}
