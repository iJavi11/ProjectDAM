namespace albartohnosDesktop.ListFRM
{
    partial class ParadasFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParadasFRM));
            this.btnUpdateStop = new System.Windows.Forms.Button();
            this.btnCreateStop = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvStops = new System.Windows.Forms.ListView();
            this.chOrden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuStop = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditarParada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerPedidosParada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCambiarEstadoParada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParadaEnProgreso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParadaOK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParadaKO = new System.Windows.Forms.ToolStripMenuItem();
            this.chEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCentroParada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombreCP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFPrev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsmiEliminarParada = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuStop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateStop
            // 
            this.btnUpdateStop.Image = global::albartohnosDesktop.Properties.Resources.action_reload_16xMD;
            this.btnUpdateStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStop.Location = new System.Drawing.Point(571, 14);
            this.btnUpdateStop.Name = "btnUpdateStop";
            this.btnUpdateStop.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateStop.TabIndex = 13;
            this.btnUpdateStop.Text = "Actualizar Lista";
            this.btnUpdateStop.UseVisualStyleBackColor = true;
            this.btnUpdateStop.Click += new System.EventHandler(this.btnUpdateStop_Click);
            // 
            // btnCreateStop
            // 
            this.btnCreateStop.Image = global::albartohnosDesktop.Properties.Resources.action_add_16xMD;
            this.btnCreateStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateStop.Location = new System.Drawing.Point(713, 14);
            this.btnCreateStop.Name = "btnCreateStop";
            this.btnCreateStop.Size = new System.Drawing.Size(180, 23);
            this.btnCreateStop.TabIndex = 12;
            this.btnCreateStop.Text = "Crear Parada de la Ruta";
            this.btnCreateStop.UseVisualStyleBackColor = true;
            this.btnCreateStop.Click += new System.EventHandler(this.btnCreateStop_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Paradas de -";
            // 
            // lvStops
            // 
            this.lvStops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStops.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOrden,
            this.chEstado,
            this.chCentroParada,
            this.chNombreCP,
            this.chFPrev});
            this.lvStops.ContextMenuStrip = this.cmsMenuStop;
            this.lvStops.FullRowSelect = true;
            this.lvStops.GridLines = true;
            this.lvStops.HideSelection = false;
            this.lvStops.Location = new System.Drawing.Point(12, 43);
            this.lvStops.Name = "lvStops";
            this.lvStops.OwnerDraw = true;
            this.lvStops.Size = new System.Drawing.Size(881, 387);
            this.lvStops.TabIndex = 10;
            this.lvStops.UseCompatibleStateImageBehavior = false;
            this.lvStops.View = System.Windows.Forms.View.Details;
            this.lvStops.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvStops_DrawColumnHeader);
            this.lvStops.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvStops_DrawSubItem);
            this.lvStops.SelectedIndexChanged += new System.EventHandler(this.lvStops_SelectedIndexChanged);
            // 
            // chOrden
            // 
            this.chOrden.Text = "Nº Parada";
            this.chOrden.Width = 66;
            // 
            // cmsMenuStop
            // 
            this.cmsMenuStop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditarParada,
            this.tsmiVerPedidosParada,
            this.tsmiCambiarEstadoParada,
            this.tsmiEliminarParada});
            this.cmsMenuStop.Name = "cmsMenuVehicle";
            this.cmsMenuStop.Size = new System.Drawing.Size(181, 114);
            this.cmsMenuStop.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuStop_Opening);
            // 
            // tsmiEditarParada
            // 
            this.tsmiEditarParada.Image = global::albartohnosDesktop.Properties.Resources.action_Edit_16xMD;
            this.tsmiEditarParada.Name = "tsmiEditarParada";
            this.tsmiEditarParada.Size = new System.Drawing.Size(180, 22);
            this.tsmiEditarParada.Text = "Editar";
            this.tsmiEditarParada.Click += new System.EventHandler(this.tsmiEditarParada_Click);
            // 
            // tsmiVerPedidosParada
            // 
            this.tsmiVerPedidosParada.Image = global::albartohnosDesktop.Properties.Resources.procedure_16xMD;
            this.tsmiVerPedidosParada.Name = "tsmiVerPedidosParada";
            this.tsmiVerPedidosParada.Size = new System.Drawing.Size(180, 22);
            this.tsmiVerPedidosParada.Text = "Ver Pedidos";
            this.tsmiVerPedidosParada.Click += new System.EventHandler(this.tsmiVerPedidosParada_Click);
            // 
            // tsmiCambiarEstadoParada
            // 
            this.tsmiCambiarEstadoParada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiParadaEnProgreso,
            this.tsmiParadaOK,
            this.tsmiParadaKO});
            this.tsmiCambiarEstadoParada.Image = global::albartohnosDesktop.Properties.Resources.Copy_6524;
            this.tsmiCambiarEstadoParada.Name = "tsmiCambiarEstadoParada";
            this.tsmiCambiarEstadoParada.Size = new System.Drawing.Size(180, 22);
            this.tsmiCambiarEstadoParada.Text = "Estados";
            // 
            // tsmiParadaEnProgreso
            // 
            this.tsmiParadaEnProgreso.Image = global::albartohnosDesktop.Properties.Resources.Redo_16x;
            this.tsmiParadaEnProgreso.Name = "tsmiParadaEnProgreso";
            this.tsmiParadaEnProgreso.Size = new System.Drawing.Size(194, 22);
            this.tsmiParadaEnProgreso.Text = "Cambiar a En Progreso";
            this.tsmiParadaEnProgreso.Click += new System.EventHandler(this.tsmiParadaEnProgreso_Click);
            // 
            // tsmiParadaOK
            // 
            this.tsmiParadaOK.Image = global::albartohnosDesktop.Properties.Resources.Redo_16x;
            this.tsmiParadaOK.Name = "tsmiParadaOK";
            this.tsmiParadaOK.Size = new System.Drawing.Size(194, 22);
            this.tsmiParadaOK.Text = "Cambiar a OK";
            this.tsmiParadaOK.Click += new System.EventHandler(this.tsmiParadaOK_Click);
            // 
            // tsmiParadaKO
            // 
            this.tsmiParadaKO.Image = global::albartohnosDesktop.Properties.Resources.Redo_16x;
            this.tsmiParadaKO.Name = "tsmiParadaKO";
            this.tsmiParadaKO.Size = new System.Drawing.Size(194, 22);
            this.tsmiParadaKO.Text = "Cambiar a KO";
            this.tsmiParadaKO.Click += new System.EventHandler(this.tsmiParadaKO_Click);
            // 
            // chEstado
            // 
            this.chEstado.Text = "Estado";
            this.chEstado.Width = 121;
            // 
            // chCentroParada
            // 
            this.chCentroParada.Text = "Centro de Parada";
            this.chCentroParada.Width = 111;
            // 
            // chNombreCP
            // 
            this.chNombreCP.Text = "Nombre";
            this.chNombreCP.Width = 413;
            // 
            // chFPrev
            // 
            this.chFPrev.Text = "Fecha Prevista";
            this.chFPrev.Width = 155;
            // 
            // tsmiEliminarParada
            // 
            this.tsmiEliminarParada.Image = global::albartohnosDesktop.Properties.Resources.action_Cancel_16xMD;
            this.tsmiEliminarParada.Name = "tsmiEliminarParada";
            this.tsmiEliminarParada.Size = new System.Drawing.Size(180, 22);
            this.tsmiEliminarParada.Text = "Eliminar";
            this.tsmiEliminarParada.Click += new System.EventHandler(this.tsmiEliminarParada_Click);
            // 
            // ParadasFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.btnUpdateStop);
            this.Controls.Add(this.btnCreateStop);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvStops);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ParadasFRM";
            this.Text = "ParadasFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParadasFRM_FormClosed);
            this.cmsMenuStop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStop;
        private System.Windows.Forms.Button btnCreateStop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvStops;
        private System.Windows.Forms.ColumnHeader chOrden;
        private System.Windows.Forms.ContextMenuStrip cmsMenuStop;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarParada;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerPedidosParada;
        private System.Windows.Forms.ToolStripMenuItem tsmiCambiarEstadoParada;
        private System.Windows.Forms.ToolStripMenuItem tsmiParadaEnProgreso;
        private System.Windows.Forms.ToolStripMenuItem tsmiParadaOK;
        private System.Windows.Forms.ToolStripMenuItem tsmiParadaKO;
        private System.Windows.Forms.ColumnHeader chEstado;
        private System.Windows.Forms.ColumnHeader chCentroParada;
        private System.Windows.Forms.ColumnHeader chNombreCP;
        private System.Windows.Forms.ColumnHeader chFPrev;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarParada;
    }
}