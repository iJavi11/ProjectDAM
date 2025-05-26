namespace albartohnosDesktop.ListFRM
{
    partial class UsuariosFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosFRM));
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.chLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPerfil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chApellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNSS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTLF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCcaa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocalidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFAlta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFBaja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCambiarPass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActivarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesactivarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Image = global::albartohnosDesktop.Properties.Resources.action_add_16xMD;
            this.btnCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUser.Location = new System.Drawing.Point(714, 11);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(136, 23);
            this.btnCreateUser.TabIndex = 8;
            this.btnCreateUser.Text = "Crear Usuario";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Listado de Usuarios";
            // 
            // lvUsers
            // 
            this.lvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLogin,
            this.chPerfil,
            this.chNombre,
            this.chApellidos,
            this.chDNI,
            this.chNSS,
            this.chActivo,
            this.chTLF,
            this.chEmail,
            this.chCcaa,
            this.chLocalidad,
            this.chDireccion,
            this.chFAlta,
            this.chFBaja});
            this.lvUsers.ContextMenuStrip = this.cmsMenuUser;
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.GridLines = true;
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(12, 43);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(838, 387);
            this.lvUsers.TabIndex = 6;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            // 
            // chLogin
            // 
            this.chLogin.Text = "ID";
            this.chLogin.Width = 104;
            // 
            // chPerfil
            // 
            this.chPerfil.Text = "Perfil";
            this.chPerfil.Width = 92;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 91;
            // 
            // chApellidos
            // 
            this.chApellidos.Text = "Apellidos";
            this.chApellidos.Width = 188;
            // 
            // chDNI
            // 
            this.chDNI.Text = "DNI";
            this.chDNI.Width = 78;
            // 
            // chNSS
            // 
            this.chNSS.Text = "NSS";
            this.chNSS.Width = 42;
            // 
            // chActivo
            // 
            this.chActivo.Text = "Activo";
            // 
            // chTLF
            // 
            this.chTLF.Text = "Teléfono";
            this.chTLF.Width = 86;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 90;
            // 
            // chCcaa
            // 
            this.chCcaa.Text = "CCAA";
            // 
            // chLocalidad
            // 
            this.chLocalidad.Text = "Localidad";
            // 
            // chDireccion
            // 
            this.chDireccion.Text = "Dirección";
            // 
            // chFAlta
            // 
            this.chFAlta.Text = "Fecha de alta";
            // 
            // chFBaja
            // 
            this.chFBaja.Text = "Fecha de baja";
            // 
            // cmsMenuUser
            // 
            this.cmsMenuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditarUsuario,
            this.tsmiCambiarPass,
            this.tsmiActivarUsuario,
            this.tsmiDesactivarUsuario,
            this.tsmiEliminarUsuario});
            this.cmsMenuUser.Name = "cmsMenuVehicle";
            this.cmsMenuUser.Size = new System.Drawing.Size(183, 114);
            this.cmsMenuUser.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuUser_Opening);
            // 
            // tsmiEditarUsuario
            // 
            this.tsmiEditarUsuario.Image = global::albartohnosDesktop.Properties.Resources.action_Edit_16xMD;
            this.tsmiEditarUsuario.Name = "tsmiEditarUsuario";
            this.tsmiEditarUsuario.Size = new System.Drawing.Size(182, 22);
            this.tsmiEditarUsuario.Text = "Editar";
            this.tsmiEditarUsuario.Click += new System.EventHandler(this.tsmiEditarUsuario_Click);
            // 
            // tsmiCambiarPass
            // 
            this.tsmiCambiarPass.Image = global::albartohnosDesktop.Properties.Resources.Copy_6524;
            this.tsmiCambiarPass.Name = "tsmiCambiarPass";
            this.tsmiCambiarPass.Size = new System.Drawing.Size(182, 22);
            this.tsmiCambiarPass.Text = "Cambiar Contraseña";
            this.tsmiCambiarPass.Click += new System.EventHandler(this.tsmiCambiarPass_Click);
            // 
            // tsmiActivarUsuario
            // 
            this.tsmiActivarUsuario.Image = global::albartohnosDesktop.Properties.Resources.CheckBox_669;
            this.tsmiActivarUsuario.Name = "tsmiActivarUsuario";
            this.tsmiActivarUsuario.Size = new System.Drawing.Size(182, 22);
            this.tsmiActivarUsuario.Text = "Activar";
            this.tsmiActivarUsuario.Click += new System.EventHandler(this.tsmiActivarUsuario_Click);
            // 
            // tsmiDesactivarUsuario
            // 
            this.tsmiDesactivarUsuario.Image = global::albartohnosDesktop.Properties.Resources.CheckBox_669;
            this.tsmiDesactivarUsuario.Name = "tsmiDesactivarUsuario";
            this.tsmiDesactivarUsuario.Size = new System.Drawing.Size(182, 22);
            this.tsmiDesactivarUsuario.Text = "Desactivar";
            this.tsmiDesactivarUsuario.Click += new System.EventHandler(this.tsmiDesactivarUsuario_Click);
            // 
            // tsmiEliminarUsuario
            // 
            this.tsmiEliminarUsuario.Image = global::albartohnosDesktop.Properties.Resources.action_Cancel_16xMD;
            this.tsmiEliminarUsuario.Name = "tsmiEliminarUsuario";
            this.tsmiEliminarUsuario.Size = new System.Drawing.Size(182, 22);
            this.tsmiEliminarUsuario.Text = "Eliminar";
            this.tsmiEliminarUsuario.Click += new System.EventHandler(this.tsmiEliminarUsuario_Click);
            // 
            // UsuariosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(862, 440);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsuariosFRM";
            this.Text = "UsuariosFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsuariosFRM_FormClosed);
            this.cmsMenuUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader chLogin;
        private System.Windows.Forms.ColumnHeader chPerfil;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chApellidos;
        private System.Windows.Forms.ColumnHeader chDNI;
        private System.Windows.Forms.ColumnHeader chNSS;
        private System.Windows.Forms.ColumnHeader chTLF;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ContextMenuStrip cmsMenuUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesactivarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarUsuario;
        private System.Windows.Forms.ColumnHeader chCcaa;
        private System.Windows.Forms.ColumnHeader chLocalidad;
        private System.Windows.Forms.ColumnHeader chActivo;
        private System.Windows.Forms.ColumnHeader chDireccion;
        private System.Windows.Forms.ColumnHeader chFAlta;
        private System.Windows.Forms.ColumnHeader chFBaja;
        private System.Windows.Forms.ToolStripMenuItem tsmiCambiarPass;
    }
}