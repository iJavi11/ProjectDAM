namespace albartohnosDesktop.CreateUpdateFRM
{
    partial class ParadaFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParadaFRM));
            this.dtpFPrev = new System.Windows.Forms.DateTimePicker();
            this.lblFPrev = new System.Windows.Forms.Label();
            this.cboEstadosParada = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodRuta = new System.Windows.Forms.TextBox();
            this.lblCodRuta = new System.Windows.Forms.Label();
            this.cboCentrosParada = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCentroParada = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpFPrev
            // 
            this.dtpFPrev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFPrev.Location = new System.Drawing.Point(492, 89);
            this.dtpFPrev.Name = "dtpFPrev";
            this.dtpFPrev.Size = new System.Drawing.Size(221, 20);
            this.dtpFPrev.TabIndex = 102;
            // 
            // lblFPrev
            // 
            this.lblFPrev.AutoSize = true;
            this.lblFPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPrev.Location = new System.Drawing.Point(370, 91);
            this.lblFPrev.Name = "lblFPrev";
            this.lblFPrev.Size = new System.Drawing.Size(100, 16);
            this.lblFPrev.TabIndex = 100;
            this.lblFPrev.Text = "Fecha Prevista:";
            // 
            // cboEstadosParada
            // 
            this.cboEstadosParada.Enabled = false;
            this.cboEstadosParada.FormattingEnabled = true;
            this.cboEstadosParada.Location = new System.Drawing.Point(457, 54);
            this.cboEstadosParada.Name = "cboEstadosParada";
            this.cboEstadosParada.Size = new System.Drawing.Size(256, 21);
            this.cboEstadosParada.TabIndex = 99;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(370, 55);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 98;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCodRuta
            // 
            this.txtCodRuta.Location = new System.Drawing.Point(134, 54);
            this.txtCodRuta.Name = "txtCodRuta";
            this.txtCodRuta.ReadOnly = true;
            this.txtCodRuta.Size = new System.Drawing.Size(230, 20);
            this.txtCodRuta.TabIndex = 97;
            // 
            // lblCodRuta
            // 
            this.lblCodRuta.AutoSize = true;
            this.lblCodRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodRuta.Location = new System.Drawing.Point(12, 55);
            this.lblCodRuta.Name = "lblCodRuta";
            this.lblCodRuta.Size = new System.Drawing.Size(118, 16);
            this.lblCodRuta.TabIndex = 96;
            this.lblCodRuta.Text = "Código de la Ruta:";
            // 
            // cboCentrosParada
            // 
            this.cboCentrosParada.FormattingEnabled = true;
            this.cboCentrosParada.Location = new System.Drawing.Point(134, 89);
            this.cboCentrosParada.Name = "cboCentrosParada";
            this.cboCentrosParada.Size = new System.Drawing.Size(229, 21);
            this.cboCentrosParada.TabIndex = 94;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(315, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 24);
            this.lblTitle.TabIndex = 92;
            this.lblTitle.Text = "Crear Parada";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(370, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 23);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(226, 164);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 23);
            this.btnAceptar.TabIndex = 90;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCentroParada
            // 
            this.lblCentroParada.AutoSize = true;
            this.lblCentroParada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroParada.Location = new System.Drawing.Point(12, 91);
            this.lblCentroParada.Name = "lblCentroParada";
            this.lblCentroParada.Size = new System.Drawing.Size(116, 16);
            this.lblCentroParada.TabIndex = 87;
            this.lblCentroParada.Text = "Centro de Parada:";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(281, 125);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(47, 16);
            this.lblOrden.TabIndex = 89;
            this.lblOrden.Text = "Orden:";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(350, 124);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(120, 20);
            this.txtOrden.TabIndex = 95;
            // 
            // ParadaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(725, 207);
            this.Controls.Add(this.dtpFPrev);
            this.Controls.Add(this.lblFPrev);
            this.Controls.Add(this.cboEstadosParada);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCodRuta);
            this.Controls.Add(this.lblCodRuta);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.cboCentrosParada);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.lblCentroParada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ParadaFRM";
            this.Text = "ParadaFRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFPrev;
        private System.Windows.Forms.Label lblFPrev;
        private System.Windows.Forms.ComboBox cboEstadosParada;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodRuta;
        private System.Windows.Forms.Label lblCodRuta;
        private System.Windows.Forms.ComboBox cboCentrosParada;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCentroParada;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.TextBox txtOrden;
    }
}