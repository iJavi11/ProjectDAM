namespace albartohnosDesktop.ListFRM
{
    partial class CentrosParadaFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentrosParadaFRM));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvStCenters = new System.Windows.Forms.ListView();
            this.chCodigoInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTipoCentro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTLF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCCAA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocalidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsStCenter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditStCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteStCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateStCenter = new System.Windows.Forms.Button();
            this.btnUpdateStCenters = new System.Windows.Forms.Button();
            this.cmsStCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Centros de Parada";
            // 
            // lvStCenters
            // 
            this.lvStCenters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStCenters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodigoInterno,
            this.chNombre,
            this.chTipoCentro,
            this.chTLF,
            this.chEmail,
            this.chCCAA,
            this.chLocalidad,
            this.chDireccion});
            this.lvStCenters.ContextMenuStrip = this.cmsStCenter;
            this.lvStCenters.FullRowSelect = true;
            this.lvStCenters.GridLines = true;
            this.lvStCenters.HideSelection = false;
            this.lvStCenters.Location = new System.Drawing.Point(12, 42);
            this.lvStCenters.Name = "lvStCenters";
            this.lvStCenters.Size = new System.Drawing.Size(983, 384);
            this.lvStCenters.TabIndex = 11;
            this.lvStCenters.UseCompatibleStateImageBehavior = false;
            this.lvStCenters.View = System.Windows.Forms.View.Details;
            this.lvStCenters.SelectedIndexChanged += new System.EventHandler(this.lvStCenters_SelectedIndexChanged);
            // 
            // chCodigoInterno
            // 
            this.chCodigoInterno.Text = "Código Interno";
            this.chCodigoInterno.Width = 91;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 139;
            // 
            // chTipoCentro
            // 
            this.chTipoCentro.Text = "Tipo de Centro";
            this.chTipoCentro.Width = 86;
            // 
            // chTLF
            // 
            this.chTLF.Text = "Teléfono";
            this.chTLF.Width = 84;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 142;
            // 
            // chCCAA
            // 
            this.chCCAA.Text = "CCAA";
            this.chCCAA.Width = 89;
            // 
            // chLocalidad
            // 
            this.chLocalidad.Text = "Localidad";
            this.chLocalidad.Width = 121;
            // 
            // chDireccion
            // 
            this.chDireccion.Text = "Dirección";
            this.chDireccion.Width = 216;
            // 
            // cmsStCenter
            // 
            this.cmsStCenter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditStCenter,
            this.tsmiDeleteStCenter});
            this.cmsStCenter.Name = "cmsMenuWh";
            this.cmsStCenter.Size = new System.Drawing.Size(118, 48);
            this.cmsStCenter.Opening += new System.ComponentModel.CancelEventHandler(this.cmsStCenter_Opening);
            // 
            // tsmiEditStCenter
            // 
            this.tsmiEditStCenter.Image = global::albartohnosDesktop.Properties.Resources.action_Edit_16xMD;
            this.tsmiEditStCenter.Name = "tsmiEditStCenter";
            this.tsmiEditStCenter.Size = new System.Drawing.Size(117, 22);
            this.tsmiEditStCenter.Text = "Editar";
            this.tsmiEditStCenter.Click += new System.EventHandler(this.tsmiEditStCenter_Click);
            // 
            // tsmiDeleteStCenter
            // 
            this.tsmiDeleteStCenter.Image = global::albartohnosDesktop.Properties.Resources.action_Cancel_16xMD;
            this.tsmiDeleteStCenter.Name = "tsmiDeleteStCenter";
            this.tsmiDeleteStCenter.Size = new System.Drawing.Size(117, 22);
            this.tsmiDeleteStCenter.Text = "Eliminar";
            this.tsmiDeleteStCenter.Click += new System.EventHandler(this.tsmiDeleteStCenter_Click);
            // 
            // btnCreateStCenter
            // 
            this.btnCreateStCenter.Image = global::albartohnosDesktop.Properties.Resources.action_add_16xMD;
            this.btnCreateStCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateStCenter.Location = new System.Drawing.Point(815, 12);
            this.btnCreateStCenter.Name = "btnCreateStCenter";
            this.btnCreateStCenter.Size = new System.Drawing.Size(180, 23);
            this.btnCreateStCenter.TabIndex = 10;
            this.btnCreateStCenter.Text = "Crear Centro de Parada";
            this.btnCreateStCenter.UseVisualStyleBackColor = true;
            this.btnCreateStCenter.Click += new System.EventHandler(this.btnCreateStCenter_Click);
            // 
            // btnUpdateStCenters
            // 
            this.btnUpdateStCenters.Image = global::albartohnosDesktop.Properties.Resources.action_reload_16xMD;
            this.btnUpdateStCenters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStCenters.Location = new System.Drawing.Point(673, 12);
            this.btnUpdateStCenters.Name = "btnUpdateStCenters";
            this.btnUpdateStCenters.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateStCenters.TabIndex = 9;
            this.btnUpdateStCenters.Text = "Actualizar Lista";
            this.btnUpdateStCenters.UseVisualStyleBackColor = true;
            this.btnUpdateStCenters.Click += new System.EventHandler(this.btnUpdateStCenters_Click);
            // 
            // CentrosParadaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1007, 438);
            this.Controls.Add(this.lvStCenters);
            this.Controls.Add(this.btnCreateStCenter);
            this.Controls.Add(this.btnUpdateStCenters);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CentrosParadaFRM";
            this.Text = "CentrosParadaFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CentrosParadaFRM_FormClosed);
            this.cmsStCenter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvStCenters;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chTLF;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chCCAA;
        private System.Windows.Forms.ColumnHeader chLocalidad;
        private System.Windows.Forms.ColumnHeader chDireccion;
        private System.Windows.Forms.Button btnCreateStCenter;
        private System.Windows.Forms.Button btnUpdateStCenters;
        private System.Windows.Forms.ColumnHeader chTipoCentro;
        private System.Windows.Forms.ContextMenuStrip cmsStCenter;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditStCenter;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteStCenter;
        private System.Windows.Forms.ColumnHeader chCodigoInterno;
    }
}