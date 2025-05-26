namespace albartohnosDesktop.ListFRM
{
    partial class VehiculosFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculosFRM));
            this.lvVehicles = new System.Windows.Forms.ListView();
            this.chMatricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapacidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFAlta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFBaja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuVehicle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditarVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActivarVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesactivarVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdateVehicles = new System.Windows.Forms.Button();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.cmsMenuVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvVehicles
            // 
            this.lvVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMatricula,
            this.chMarca,
            this.chModelo,
            this.chDescripcion,
            this.chCapacidad,
            this.chActivo,
            this.chFAlta,
            this.chFBaja});
            this.lvVehicles.ContextMenuStrip = this.cmsMenuVehicle;
            this.lvVehicles.FullRowSelect = true;
            this.lvVehicles.GridLines = true;
            this.lvVehicles.HideSelection = false;
            this.lvVehicles.Location = new System.Drawing.Point(12, 41);
            this.lvVehicles.Name = "lvVehicles";
            this.lvVehicles.Size = new System.Drawing.Size(776, 387);
            this.lvVehicles.TabIndex = 0;
            this.lvVehicles.UseCompatibleStateImageBehavior = false;
            this.lvVehicles.View = System.Windows.Forms.View.Details;
            this.lvVehicles.SelectedIndexChanged += new System.EventHandler(this.lvVehicles_SelectedIndexChanged);
            // 
            // chMatricula
            // 
            this.chMatricula.Text = "Matricula";
            this.chMatricula.Width = 104;
            // 
            // chMarca
            // 
            this.chMarca.Text = "Marca";
            this.chMarca.Width = 92;
            // 
            // chModelo
            // 
            this.chModelo.Text = "Modelo";
            this.chModelo.Width = 91;
            // 
            // chDescripcion
            // 
            this.chDescripcion.Text = "Descripción";
            this.chDescripcion.Width = 188;
            // 
            // chCapacidad
            // 
            this.chCapacidad.Text = "Capacidad";
            this.chCapacidad.Width = 78;
            // 
            // chActivo
            // 
            this.chActivo.Text = "Activo";
            this.chActivo.Width = 42;
            // 
            // chFAlta
            // 
            this.chFAlta.Text = "Fecha de Alta";
            this.chFAlta.Width = 86;
            // 
            // chFBaja
            // 
            this.chFBaja.Text = "Fecha de Baja";
            this.chFBaja.Width = 90;
            // 
            // cmsMenuVehicle
            // 
            this.cmsMenuVehicle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditarVehiculo,
            this.tsmiActivarVehiculo,
            this.tsmiDesactivarVehiculo,
            this.tsmiEliminarVehiculo});
            this.cmsMenuVehicle.Name = "cmsMenuVehicle";
            this.cmsMenuVehicle.Size = new System.Drawing.Size(129, 92);
            this.cmsMenuVehicle.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuVehicle_Opening);
            // 
            // tsmiEditarVehiculo
            // 
            this.tsmiEditarVehiculo.Image = global::albartohnosDesktop.Properties.Resources.action_Edit_16xMD;
            this.tsmiEditarVehiculo.Name = "tsmiEditarVehiculo";
            this.tsmiEditarVehiculo.Size = new System.Drawing.Size(128, 22);
            this.tsmiEditarVehiculo.Text = "Editar";
            this.tsmiEditarVehiculo.Click += new System.EventHandler(this.tsmiEditarVehiculo_Click);
            // 
            // tsmiActivarVehiculo
            // 
            this.tsmiActivarVehiculo.Image = global::albartohnosDesktop.Properties.Resources.CheckBox_669;
            this.tsmiActivarVehiculo.Name = "tsmiActivarVehiculo";
            this.tsmiActivarVehiculo.Size = new System.Drawing.Size(128, 22);
            this.tsmiActivarVehiculo.Text = "Activar";
            this.tsmiActivarVehiculo.Click += new System.EventHandler(this.tsmiActivarVehiculo_Click);
            // 
            // tsmiDesactivarVehiculo
            // 
            this.tsmiDesactivarVehiculo.Image = global::albartohnosDesktop.Properties.Resources.CheckBox_669;
            this.tsmiDesactivarVehiculo.Name = "tsmiDesactivarVehiculo";
            this.tsmiDesactivarVehiculo.Size = new System.Drawing.Size(128, 22);
            this.tsmiDesactivarVehiculo.Text = "Desactivar";
            this.tsmiDesactivarVehiculo.Click += new System.EventHandler(this.tsmiDesactivarVehiculo_Click);
            // 
            // tsmiEliminarVehiculo
            // 
            this.tsmiEliminarVehiculo.Image = global::albartohnosDesktop.Properties.Resources.action_Cancel_16xMD;
            this.tsmiEliminarVehiculo.Name = "tsmiEliminarVehiculo";
            this.tsmiEliminarVehiculo.Size = new System.Drawing.Size(128, 22);
            this.tsmiEliminarVehiculo.Text = "Eliminar";
            this.tsmiEliminarVehiculo.Click += new System.EventHandler(this.tsmiEliminarVehiculo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Listado de Vehículos";
            // 
            // btnUpdateVehicles
            // 
            this.btnUpdateVehicles.Image = global::albartohnosDesktop.Properties.Resources.action_reload_16xMD;
            this.btnUpdateVehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateVehicles.Location = new System.Drawing.Point(510, 12);
            this.btnUpdateVehicles.Name = "btnUpdateVehicles";
            this.btnUpdateVehicles.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateVehicles.TabIndex = 5;
            this.btnUpdateVehicles.Text = "Actualizar Lista";
            this.btnUpdateVehicles.UseVisualStyleBackColor = true;
            this.btnUpdateVehicles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUpdateVehicles_MouseClick);
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Image = global::albartohnosDesktop.Properties.Resources.action_add_16xMD;
            this.btnCreateVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateVehicle.Location = new System.Drawing.Point(652, 12);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(136, 23);
            this.btnCreateVehicle.TabIndex = 3;
            this.btnCreateVehicle.Text = "Crear Vehículo";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            this.btnCreateVehicle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCreateVehicle_MouseClick);
            // 
            // VehiculosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btnUpdateVehicles);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvVehicles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VehiculosFRM";
            this.Text = "VehiculosFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehiculosFRM_FormClosed);
            this.cmsMenuVehicle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVehicles;
        private System.Windows.Forms.ColumnHeader chMatricula;
        private System.Windows.Forms.ColumnHeader chMarca;
        private System.Windows.Forms.ColumnHeader chModelo;
        private System.Windows.Forms.ColumnHeader chDescripcion;
        private System.Windows.Forms.ColumnHeader chCapacidad;
        private System.Windows.Forms.ColumnHeader chActivo;
        private System.Windows.Forms.ColumnHeader chFAlta;
        private System.Windows.Forms.ColumnHeader chFBaja;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.ContextMenuStrip cmsMenuVehicle;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarVehiculo;
        private System.Windows.Forms.Button btnUpdateVehicles;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivarVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesactivarVehiculo;
    }
}