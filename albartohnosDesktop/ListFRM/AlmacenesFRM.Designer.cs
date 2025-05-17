namespace albartohnosDesktop.ListFRM
{
    partial class AlmacenesFRM
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvWh = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTLF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCCAA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocalidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateWh = new System.Windows.Forms.Button();
            this.btnUpdateWh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Almacenes";
            // 
            // lvWh
            // 
            this.lvWh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvWh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chTLF,
            this.chEmail,
            this.chCCAA,
            this.chLocalidad,
            this.chDireccion});
            this.lvWh.FullRowSelect = true;
            this.lvWh.GridLines = true;
            this.lvWh.HideSelection = false;
            this.lvWh.Location = new System.Drawing.Point(12, 42);
            this.lvWh.Name = "lvWh";
            this.lvWh.Size = new System.Drawing.Size(983, 384);
            this.lvWh.TabIndex = 8;
            this.lvWh.UseCompatibleStateImageBehavior = false;
            this.lvWh.View = System.Windows.Forms.View.Details;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 104;
            // 
            // chTLF
            // 
            this.chTLF.Text = "Teléfono";
            this.chTLF.Width = 92;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 91;
            // 
            // chCCAA
            // 
            this.chCCAA.Text = "CCAA";
            this.chCCAA.Width = 138;
            // 
            // chLocalidad
            // 
            this.chLocalidad.Text = "Localidad";
            this.chLocalidad.Width = 127;
            // 
            // chDireccion
            // 
            this.chDireccion.Text = "Dirección";
            this.chDireccion.Width = 217;
            // 
            // btnCreateWh
            // 
            this.btnCreateWh.Image = global::albartohnosDesktop.Properties.Resources.action_add_16xMD;
            this.btnCreateWh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateWh.Location = new System.Drawing.Point(859, 12);
            this.btnCreateWh.Name = "btnCreateWh";
            this.btnCreateWh.Size = new System.Drawing.Size(136, 23);
            this.btnCreateWh.TabIndex = 7;
            this.btnCreateWh.Text = "Crear Almacén";
            this.btnCreateWh.UseVisualStyleBackColor = true;
            // 
            // btnUpdateWh
            // 
            this.btnUpdateWh.Image = global::albartohnosDesktop.Properties.Resources.action_reload_16xMD;
            this.btnUpdateWh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateWh.Location = new System.Drawing.Point(717, 12);
            this.btnUpdateWh.Name = "btnUpdateWh";
            this.btnUpdateWh.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateWh.TabIndex = 6;
            this.btnUpdateWh.Text = "Actualizar Lista";
            this.btnUpdateWh.UseVisualStyleBackColor = true;
            this.btnUpdateWh.Click += new System.EventHandler(this.btnUpdateWh_Click);
            // 
            // AlmacenesFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1007, 438);
            this.Controls.Add(this.lvWh);
            this.Controls.Add(this.btnCreateWh);
            this.Controls.Add(this.btnUpdateWh);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlmacenesFRM";
            this.Text = "AlmacenesFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlmacenesFRM_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpdateWh;
        private System.Windows.Forms.Button btnCreateWh;
        private System.Windows.Forms.ListView lvWh;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chTLF;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chCCAA;
        private System.Windows.Forms.ColumnHeader chLocalidad;
        private System.Windows.Forms.ColumnHeader chDireccion;
    }
}