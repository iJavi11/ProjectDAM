namespace albartohnosDesktop.ListFRM
{
    partial class RutasFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RutasFRM));
            this.btnUpdateRoutes = new System.Windows.Forms.Button();
            this.btnCreateRoute = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvRoutes = new System.Windows.Forms.ListView();
            this.chCodRuta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chConductor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVehiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFPrevInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFPrevBaja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuRoute = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditarRuta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerParadasRuta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCambiarEstadoRuta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRutaPlanificada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRutaEnProgreso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRutaFinalizada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarRuta = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuRoute.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateRoutes
            // 
            this.btnUpdateRoutes.Image = global::albartohnosDesktop.Properties.Resources.action_reload_16xMD;
            this.btnUpdateRoutes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRoutes.Location = new System.Drawing.Point(615, 12);
            this.btnUpdateRoutes.Name = "btnUpdateRoutes";
            this.btnUpdateRoutes.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateRoutes.TabIndex = 9;
            this.btnUpdateRoutes.Text = "Actualizar Lista";
            this.btnUpdateRoutes.UseVisualStyleBackColor = true;
            this.btnUpdateRoutes.Click += new System.EventHandler(this.btnUpdateRoutes_Click);
            // 
            // btnCreateRoute
            // 
            this.btnCreateRoute.Image = global::albartohnosDesktop.Properties.Resources.action_add_16xMD;
            this.btnCreateRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateRoute.Location = new System.Drawing.Point(757, 12);
            this.btnCreateRoute.Name = "btnCreateRoute";
            this.btnCreateRoute.Size = new System.Drawing.Size(136, 23);
            this.btnCreateRoute.TabIndex = 8;
            this.btnCreateRoute.Text = "Crear Ruta";
            this.btnCreateRoute.UseVisualStyleBackColor = true;
            this.btnCreateRoute.Click += new System.EventHandler(this.btnCreateRoute_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Listado de Rutas";
            // 
            // lvRoutes
            // 
            this.lvRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRoutes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodRuta,
            this.chEstado,
            this.chDescripcion,
            this.chConductor,
            this.chVehiculo,
            this.chFPrevInicio,
            this.chFPrevBaja});
            this.lvRoutes.ContextMenuStrip = this.cmsMenuRoute;
            this.lvRoutes.FullRowSelect = true;
            this.lvRoutes.GridLines = true;
            this.lvRoutes.HideSelection = false;
            this.lvRoutes.Location = new System.Drawing.Point(12, 41);
            this.lvRoutes.Name = "lvRoutes";
            this.lvRoutes.OwnerDraw = true;
            this.lvRoutes.Size = new System.Drawing.Size(881, 387);
            this.lvRoutes.TabIndex = 6;
            this.lvRoutes.UseCompatibleStateImageBehavior = false;
            this.lvRoutes.View = System.Windows.Forms.View.Details;
            this.lvRoutes.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvRoutes_DrawColumnHeader);
            this.lvRoutes.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvRoutes_DrawSubItem);
            this.lvRoutes.SelectedIndexChanged += new System.EventHandler(this.lvRoutes_SelectedIndexChanged);
            // 
            // chCodRuta
            // 
            this.chCodRuta.Text = "Código de Ruta";
            this.chCodRuta.Width = 93;
            // 
            // chEstado
            // 
            this.chEstado.Text = "Estado";
            this.chEstado.Width = 104;
            // 
            // chDescripcion
            // 
            this.chDescripcion.Text = "Descripción";
            this.chDescripcion.Width = 183;
            // 
            // chConductor
            // 
            this.chConductor.Text = "Conductor";
            this.chConductor.Width = 93;
            // 
            // chVehiculo
            // 
            this.chVehiculo.Text = "Vehiculo";
            this.chVehiculo.Width = 93;
            // 
            // chFPrevInicio
            // 
            this.chFPrevInicio.Text = "Fecha Prevista de Inicio";
            this.chFPrevInicio.Width = 144;
            // 
            // chFPrevBaja
            // 
            this.chFPrevBaja.Text = "Fecha Prevista de Fin";
            this.chFPrevBaja.Width = 143;
            // 
            // cmsMenuRoute
            // 
            this.cmsMenuRoute.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditarRuta,
            this.tsmiVerParadasRuta,
            this.tsmiCambiarEstadoRuta,
            this.tsmiEliminarRuta});
            this.cmsMenuRoute.Name = "cmsMenuVehicle";
            this.cmsMenuRoute.Size = new System.Drawing.Size(181, 114);
            this.cmsMenuRoute.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuRoute_Opening);
            // 
            // tsmiEditarRuta
            // 
            this.tsmiEditarRuta.Image = global::albartohnosDesktop.Properties.Resources.action_Edit_16xMD;
            this.tsmiEditarRuta.Name = "tsmiEditarRuta";
            this.tsmiEditarRuta.Size = new System.Drawing.Size(180, 22);
            this.tsmiEditarRuta.Text = "Editar";
            this.tsmiEditarRuta.Click += new System.EventHandler(this.tsmiEditarRuta_Click);
            // 
            // tsmiVerParadasRuta
            // 
            this.tsmiVerParadasRuta.Image = global::albartohnosDesktop.Properties.Resources.procedure_16xMD;
            this.tsmiVerParadasRuta.Name = "tsmiVerParadasRuta";
            this.tsmiVerParadasRuta.Size = new System.Drawing.Size(180, 22);
            this.tsmiVerParadasRuta.Text = "Ver Paradas";
            this.tsmiVerParadasRuta.Click += new System.EventHandler(this.tsmiVerParadasRuta_Click);
            // 
            // tsmiCambiarEstadoRuta
            // 
            this.tsmiCambiarEstadoRuta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRutaPlanificada,
            this.tsmiRutaEnProgreso,
            this.tsmiRutaFinalizada});
            this.tsmiCambiarEstadoRuta.Image = global::albartohnosDesktop.Properties.Resources.Copy_6524;
            this.tsmiCambiarEstadoRuta.Name = "tsmiCambiarEstadoRuta";
            this.tsmiCambiarEstadoRuta.Size = new System.Drawing.Size(180, 22);
            this.tsmiCambiarEstadoRuta.Text = "Estados";
            // 
            // tsmiRutaPlanificada
            // 
            this.tsmiRutaPlanificada.Image = global::albartohnosDesktop.Properties.Resources.Redo_16x;
            this.tsmiRutaPlanificada.Name = "tsmiRutaPlanificada";
            this.tsmiRutaPlanificada.Size = new System.Drawing.Size(194, 22);
            this.tsmiRutaPlanificada.Text = "Cambiar a Planificada";
            this.tsmiRutaPlanificada.Click += new System.EventHandler(this.tsmiRutaPlanificada_Click);
            // 
            // tsmiRutaEnProgreso
            // 
            this.tsmiRutaEnProgreso.Image = global::albartohnosDesktop.Properties.Resources.Redo_16x;
            this.tsmiRutaEnProgreso.Name = "tsmiRutaEnProgreso";
            this.tsmiRutaEnProgreso.Size = new System.Drawing.Size(194, 22);
            this.tsmiRutaEnProgreso.Text = "Cambiar a En Progreso";
            this.tsmiRutaEnProgreso.Click += new System.EventHandler(this.tsmiRutaEnProgreso_Click);
            // 
            // tsmiRutaFinalizada
            // 
            this.tsmiRutaFinalizada.Image = global::albartohnosDesktop.Properties.Resources.Redo_16x;
            this.tsmiRutaFinalizada.Name = "tsmiRutaFinalizada";
            this.tsmiRutaFinalizada.Size = new System.Drawing.Size(194, 22);
            this.tsmiRutaFinalizada.Text = "Cambiar a Finalizada";
            this.tsmiRutaFinalizada.Click += new System.EventHandler(this.tsmiRutaFinalizada_Click);
            // 
            // tsmiEliminarRuta
            // 
            this.tsmiEliminarRuta.Image = global::albartohnosDesktop.Properties.Resources.action_Cancel_16xMD;
            this.tsmiEliminarRuta.Name = "tsmiEliminarRuta";
            this.tsmiEliminarRuta.Size = new System.Drawing.Size(180, 22);
            this.tsmiEliminarRuta.Text = "Eliminar";
            this.tsmiEliminarRuta.Click += new System.EventHandler(this.tsmiEliminarRuta_Click);
            // 
            // RutasFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.btnUpdateRoutes);
            this.Controls.Add(this.btnCreateRoute);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvRoutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RutasFRM";
            this.Text = "RutasFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RutasFRM_FormClosed);
            this.cmsMenuRoute.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateRoutes;
        private System.Windows.Forms.Button btnCreateRoute;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvRoutes;
        private System.Windows.Forms.ColumnHeader chCodRuta;
        private System.Windows.Forms.ColumnHeader chEstado;
        private System.Windows.Forms.ColumnHeader chDescripcion;
        private System.Windows.Forms.ColumnHeader chConductor;
        private System.Windows.Forms.ColumnHeader chVehiculo;
        private System.Windows.Forms.ColumnHeader chFPrevInicio;
        private System.Windows.Forms.ColumnHeader chFPrevBaja;
        private System.Windows.Forms.ContextMenuStrip cmsMenuRoute;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarRuta;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerParadasRuta;
        private System.Windows.Forms.ToolStripMenuItem tsmiCambiarEstadoRuta;
        private System.Windows.Forms.ToolStripMenuItem tsmiRutaPlanificada;
        private System.Windows.Forms.ToolStripMenuItem tsmiRutaEnProgreso;
        private System.Windows.Forms.ToolStripMenuItem tsmiRutaFinalizada;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarRuta;
    }
}