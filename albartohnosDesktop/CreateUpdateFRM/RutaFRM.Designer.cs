namespace albartohnosDesktop.CreateUpdateFRM
{
    partial class RutaFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RutaFRM));
            this.dtpFPrevFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFPrevInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFPrevFin = new System.Windows.Forms.Label();
            this.lblFPrevInicio = new System.Windows.Forms.Label();
            this.cboEstadosRuta = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodRuta = new System.Windows.Forms.TextBox();
            this.lblCodRuta = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboConductores = new System.Windows.Forms.ComboBox();
            this.cboVehiculos = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblConductor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFPrevFin
            // 
            this.dtpFPrevFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFPrevFin.Location = new System.Drawing.Point(565, 199);
            this.dtpFPrevFin.Name = "dtpFPrevFin";
            this.dtpFPrevFin.Size = new System.Drawing.Size(145, 20);
            this.dtpFPrevFin.TabIndex = 86;
            // 
            // dtpFPrevInicio
            // 
            this.dtpFPrevInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFPrevInicio.Location = new System.Drawing.Point(168, 199);
            this.dtpFPrevInicio.Name = "dtpFPrevInicio";
            this.dtpFPrevInicio.Size = new System.Drawing.Size(193, 20);
            this.dtpFPrevInicio.TabIndex = 85;
            // 
            // lblFPrevFin
            // 
            this.lblFPrevFin.AutoSize = true;
            this.lblFPrevFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPrevFin.Location = new System.Drawing.Point(366, 201);
            this.lblFPrevFin.Name = "lblFPrevFin";
            this.lblFPrevFin.Size = new System.Drawing.Size(193, 16);
            this.lblFPrevFin.TabIndex = 84;
            this.lblFPrevFin.Text = "Fecha Prevista de Finalización:";
            // 
            // lblFPrevInicio
            // 
            this.lblFPrevInicio.AutoSize = true;
            this.lblFPrevInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPrevInicio.Location = new System.Drawing.Point(9, 201);
            this.lblFPrevInicio.Name = "lblFPrevInicio";
            this.lblFPrevInicio.Size = new System.Drawing.Size(153, 16);
            this.lblFPrevInicio.TabIndex = 83;
            this.lblFPrevInicio.Text = "Fecha Prevista de Inicio:";
            // 
            // cboEstadosRuta
            // 
            this.cboEstadosRuta.FormattingEnabled = true;
            this.cboEstadosRuta.Location = new System.Drawing.Point(454, 55);
            this.cboEstadosRuta.Name = "cboEstadosRuta";
            this.cboEstadosRuta.Size = new System.Drawing.Size(256, 21);
            this.cboEstadosRuta.TabIndex = 82;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(367, 56);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 81;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCodRuta
            // 
            this.txtCodRuta.Location = new System.Drawing.Point(131, 55);
            this.txtCodRuta.Name = "txtCodRuta";
            this.txtCodRuta.Size = new System.Drawing.Size(230, 20);
            this.txtCodRuta.TabIndex = 80;
            // 
            // lblCodRuta
            // 
            this.lblCodRuta.AutoSize = true;
            this.lblCodRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodRuta.Location = new System.Drawing.Point(9, 56);
            this.lblCodRuta.Name = "lblCodRuta";
            this.lblCodRuta.Size = new System.Drawing.Size(118, 16);
            this.lblCodRuta.TabIndex = 79;
            this.lblCodRuta.Text = "Código de la Ruta:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(131, 129);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(579, 49);
            this.txtDescripcion.TabIndex = 78;
            // 
            // cboConductores
            // 
            this.cboConductores.FormattingEnabled = true;
            this.cboConductores.Location = new System.Drawing.Point(131, 90);
            this.cboConductores.Name = "cboConductores";
            this.cboConductores.Size = new System.Drawing.Size(229, 21);
            this.cboConductores.TabIndex = 77;
            // 
            // cboVehiculos
            // 
            this.cboVehiculos.FormattingEnabled = true;
            this.cboVehiculos.Location = new System.Drawing.Point(454, 90);
            this.cboVehiculos.Name = "cboVehiculos";
            this.cboVehiculos.Size = new System.Drawing.Size(256, 21);
            this.cboVehiculos.TabIndex = 76;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(321, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 24);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Crear Ruta";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(380, 254);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 23);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(236, 254);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 23);
            this.btnAceptar.TabIndex = 73;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 130);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 72;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(366, 93);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(62, 16);
            this.lblVehiculo.TabIndex = 71;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductor.Location = new System.Drawing.Point(9, 92);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(71, 16);
            this.lblConductor.TabIndex = 70;
            this.lblConductor.Text = "Conductor:";
            // 
            // RutaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(725, 289);
            this.Controls.Add(this.dtpFPrevFin);
            this.Controls.Add(this.dtpFPrevInicio);
            this.Controls.Add(this.lblFPrevFin);
            this.Controls.Add(this.lblFPrevInicio);
            this.Controls.Add(this.cboEstadosRuta);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCodRuta);
            this.Controls.Add(this.lblCodRuta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cboConductores);
            this.Controls.Add(this.cboVehiculos);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblConductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RutaFRM";
            this.Text = "RutaFRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFPrevFin;
        private System.Windows.Forms.DateTimePicker dtpFPrevInicio;
        private System.Windows.Forms.Label lblFPrevFin;
        private System.Windows.Forms.Label lblFPrevInicio;
        private System.Windows.Forms.ComboBox cboEstadosRuta;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodRuta;
        private System.Windows.Forms.Label lblCodRuta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboConductores;
        private System.Windows.Forms.ComboBox cboVehiculos;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblConductor;
    }
}