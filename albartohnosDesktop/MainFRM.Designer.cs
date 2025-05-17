namespace albartohnosDesktop
{
    partial class MainFRM
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblModuleQ = new System.Windows.Forms.Label();
            this.btnUsersModule = new System.Windows.Forms.Button();
            this.btnVehiclesModule = new System.Windows.Forms.Button();
            this.btnProductsModule = new System.Windows.Forms.Button();
            this.btnWhModule = new System.Windows.Forms.Button();
            this.btnRoutesModule = new System.Windows.Forms.Button();
            this.btnStCentersModule = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.tsmiLogOut});
            this.msMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msMainMenu.Size = new System.Drawing.Size(167, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "msMainMenu";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(88, 20);
            this.tsmiLogOut.Text = "Cerrar Sesión";
            this.tsmiLogOut.Click += new System.EventHandler(this.tsmiLogOut_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(13, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(204, 37);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Bienvenido -";
            // 
            // lblModuleQ
            // 
            this.lblModuleQ.AutoSize = true;
            this.lblModuleQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleQ.Location = new System.Drawing.Point(223, 132);
            this.lblModuleQ.Name = "lblModuleQ";
            this.lblModuleQ.Size = new System.Drawing.Size(362, 31);
            this.lblModuleQ.TabIndex = 2;
            this.lblModuleQ.Text = "¿Qué Módulo desea Utilizar?";
            // 
            // btnUsersModule
            // 
            this.btnUsersModule.Location = new System.Drawing.Point(12, 180);
            this.btnUsersModule.Name = "btnUsersModule";
            this.btnUsersModule.Size = new System.Drawing.Size(256, 37);
            this.btnUsersModule.TabIndex = 3;
            this.btnUsersModule.Text = "Usuarios";
            this.btnUsersModule.UseVisualStyleBackColor = true;
            // 
            // btnVehiclesModule
            // 
            this.btnVehiclesModule.Location = new System.Drawing.Point(274, 180);
            this.btnVehiclesModule.Name = "btnVehiclesModule";
            this.btnVehiclesModule.Size = new System.Drawing.Size(261, 37);
            this.btnVehiclesModule.TabIndex = 4;
            this.btnVehiclesModule.Text = "Vehículos";
            this.btnVehiclesModule.UseVisualStyleBackColor = true;
            this.btnVehiclesModule.Click += new System.EventHandler(this.btnVehiclesModule_Click);
            // 
            // btnProductsModule
            // 
            this.btnProductsModule.Location = new System.Drawing.Point(12, 223);
            this.btnProductsModule.Name = "btnProductsModule";
            this.btnProductsModule.Size = new System.Drawing.Size(256, 37);
            this.btnProductsModule.TabIndex = 6;
            this.btnProductsModule.Text = "Productos";
            this.btnProductsModule.UseVisualStyleBackColor = true;
            // 
            // btnWhModule
            // 
            this.btnWhModule.Location = new System.Drawing.Point(541, 180);
            this.btnWhModule.Name = "btnWhModule";
            this.btnWhModule.Size = new System.Drawing.Size(261, 37);
            this.btnWhModule.TabIndex = 7;
            this.btnWhModule.Text = "Almacenes";
            this.btnWhModule.UseVisualStyleBackColor = true;
            this.btnWhModule.Click += new System.EventHandler(this.btnWhModule_Click);
            // 
            // btnRoutesModule
            // 
            this.btnRoutesModule.Location = new System.Drawing.Point(274, 223);
            this.btnRoutesModule.Name = "btnRoutesModule";
            this.btnRoutesModule.Size = new System.Drawing.Size(261, 37);
            this.btnRoutesModule.TabIndex = 8;
            this.btnRoutesModule.Text = "Rutas";
            this.btnRoutesModule.UseVisualStyleBackColor = true;
            // 
            // btnStCentersModule
            // 
            this.btnStCentersModule.Location = new System.Drawing.Point(541, 223);
            this.btnStCentersModule.Name = "btnStCentersModule";
            this.btnStCentersModule.Size = new System.Drawing.Size(261, 37);
            this.btnStCentersModule.TabIndex = 9;
            this.btnStCentersModule.Text = "Centros de Parada";
            this.btnStCentersModule.UseVisualStyleBackColor = true;
            this.btnStCentersModule.Click += new System.EventHandler(this.btnStCentersModule_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(53, 92);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 15);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Estamos a día -";
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(815, 318);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnStCentersModule);
            this.Controls.Add(this.btnRoutesModule);
            this.Controls.Add(this.btnWhModule);
            this.Controls.Add(this.btnProductsModule);
            this.Controls.Add(this.btnVehiclesModule);
            this.Controls.Add(this.btnUsersModule);
            this.Controls.Add(this.lblModuleQ);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.Name = "MainFRM";
            this.Text = "MainFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFRM_FormClosed);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogOut;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblModuleQ;
        private System.Windows.Forms.Button btnUsersModule;
        private System.Windows.Forms.Button btnVehiclesModule;
        private System.Windows.Forms.Button btnProductsModule;
        private System.Windows.Forms.Button btnWhModule;
        private System.Windows.Forms.Button btnRoutesModule;
        private System.Windows.Forms.Button btnStCentersModule;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolTip toolTip;
    }
}