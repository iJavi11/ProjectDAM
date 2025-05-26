namespace albartohnosDesktop.CreateUpdateFRM
{
    partial class UsuarioPasswdFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioPasswdFRM));
            this.txtNewPasswd1 = new System.Windows.Forms.TextBox();
            this.lblNewPasswd1 = new System.Windows.Forms.Label();
            this.txtNewPasswd2 = new System.Windows.Forms.TextBox();
            this.lblNewPasswd2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewPasswd1
            // 
            this.txtNewPasswd1.Location = new System.Drawing.Point(219, 18);
            this.txtNewPasswd1.Name = "txtNewPasswd1";
            this.txtNewPasswd1.PasswordChar = '•';
            this.txtNewPasswd1.Size = new System.Drawing.Size(204, 20);
            this.txtNewPasswd1.TabIndex = 76;
            this.txtNewPasswd1.UseSystemPasswordChar = true;
            // 
            // lblNewPasswd1
            // 
            this.lblNewPasswd1.AutoSize = true;
            this.lblNewPasswd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswd1.Location = new System.Drawing.Point(12, 20);
            this.lblNewPasswd1.Name = "lblNewPasswd1";
            this.lblNewPasswd1.Size = new System.Drawing.Size(197, 16);
            this.lblNewPasswd1.TabIndex = 75;
            this.lblNewPasswd1.Text = "Introduzca la nueva Contraseña:";
            // 
            // txtNewPasswd2
            // 
            this.txtNewPasswd2.Location = new System.Drawing.Point(219, 50);
            this.txtNewPasswd2.Name = "txtNewPasswd2";
            this.txtNewPasswd2.PasswordChar = '•';
            this.txtNewPasswd2.Size = new System.Drawing.Size(204, 20);
            this.txtNewPasswd2.TabIndex = 78;
            this.txtNewPasswd2.UseSystemPasswordChar = true;
            // 
            // lblNewPasswd2
            // 
            this.lblNewPasswd2.AutoSize = true;
            this.lblNewPasswd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswd2.Location = new System.Drawing.Point(12, 51);
            this.lblNewPasswd2.Name = "lblNewPasswd2";
            this.lblNewPasswd2.Size = new System.Drawing.Size(201, 16);
            this.lblNewPasswd2.TabIndex = 77;
            this.lblNewPasswd2.Text = "Escribe de nuevo la Contraseña:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(219, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 23);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(75, 93);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 23);
            this.btnAceptar.TabIndex = 79;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // UsuarioPasswdFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(440, 128);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNewPasswd2);
            this.Controls.Add(this.lblNewPasswd2);
            this.Controls.Add(this.txtNewPasswd1);
            this.Controls.Add(this.lblNewPasswd1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsuarioPasswdFRM";
            this.Text = "UsuarioPasswdFRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPasswd1;
        private System.Windows.Forms.Label lblNewPasswd1;
        private System.Windows.Forms.TextBox txtNewPasswd2;
        private System.Windows.Forms.Label lblNewPasswd2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}