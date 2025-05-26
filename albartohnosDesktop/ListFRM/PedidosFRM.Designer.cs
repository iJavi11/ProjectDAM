namespace albartohnosDesktop.ListFRM
{
    partial class PedidosFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosFRM));
            this.btnUpdateOrders = new System.Windows.Forms.Button();
            this.btnCreateOrders = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.chCodPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCambiarEstadoPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPedidoOK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPedidoParcial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPedidoKO = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.chPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateOrders
            // 
            this.btnUpdateOrders.Image = global::albartohnosDesktop.Properties.Resources.action_reload_16xMD;
            this.btnUpdateOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateOrders.Location = new System.Drawing.Point(627, 16);
            this.btnUpdateOrders.Name = "btnUpdateOrders";
            this.btnUpdateOrders.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateOrders.TabIndex = 17;
            this.btnUpdateOrders.Text = "Actualizar Lista";
            this.btnUpdateOrders.UseVisualStyleBackColor = true;
            this.btnUpdateOrders.Click += new System.EventHandler(this.btnUpdateOrders_Click);
            // 
            // btnCreateOrders
            // 
            this.btnCreateOrders.Image = global::albartohnosDesktop.Properties.Resources.action_add_16xMD;
            this.btnCreateOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateOrders.Location = new System.Drawing.Point(769, 16);
            this.btnCreateOrders.Name = "btnCreateOrders";
            this.btnCreateOrders.Size = new System.Drawing.Size(124, 23);
            this.btnCreateOrders.TabIndex = 16;
            this.btnCreateOrders.Text = "Crear Pedido";
            this.btnCreateOrders.UseVisualStyleBackColor = true;
            this.btnCreateOrders.Click += new System.EventHandler(this.btnCreateOrders_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 24);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Lista de Pedidos de la Parada";
            // 
            // lvOrders
            // 
            this.lvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodPedido,
            this.chProducto,
            this.chTipo,
            this.chEstado,
            this.chCantidad,
            this.chPrecio});
            this.lvOrders.ContextMenuStrip = this.cmsMenuOrder;
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.GridLines = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(12, 45);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.OwnerDraw = true;
            this.lvOrders.Size = new System.Drawing.Size(881, 387);
            this.lvOrders.TabIndex = 14;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvOrders_DrawColumnHeader);
            this.lvOrders.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvOrders_DrawSubItem);
            this.lvOrders.SelectedIndexChanged += new System.EventHandler(this.lvOrders_SelectedIndexChanged);
            // 
            // chCodPedido
            // 
            this.chCodPedido.Text = "Código del Pedido";
            this.chCodPedido.Width = 164;
            // 
            // chProducto
            // 
            this.chProducto.Text = "Producto";
            this.chProducto.Width = 301;
            // 
            // chTipo
            // 
            this.chTipo.Text = "Tipo de Pedido";
            this.chTipo.Width = 132;
            // 
            // chEstado
            // 
            this.chEstado.Text = "Estado";
            this.chEstado.Width = 74;
            // 
            // chCantidad
            // 
            this.chCantidad.Text = "Cantidad";
            this.chCantidad.Width = 70;
            // 
            // cmsMenuOrder
            // 
            this.cmsMenuOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditarPedido,
            this.tsmiCambiarEstadoPedido,
            this.tsmiEliminarPedido});
            this.cmsMenuOrder.Name = "cmsMenuVehicle";
            this.cmsMenuOrder.Size = new System.Drawing.Size(181, 92);
            this.cmsMenuOrder.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuOrder_Opening);
            // 
            // tsmiEditarPedido
            // 
            this.tsmiEditarPedido.Image = global::albartohnosDesktop.Properties.Resources.action_Edit_16xMD;
            this.tsmiEditarPedido.Name = "tsmiEditarPedido";
            this.tsmiEditarPedido.Size = new System.Drawing.Size(180, 22);
            this.tsmiEditarPedido.Text = "Editar";
            this.tsmiEditarPedido.Click += new System.EventHandler(this.tsmiEditarPedido_Click);
            // 
            // tsmiCambiarEstadoPedido
            // 
            this.tsmiCambiarEstadoPedido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPedidoOK,
            this.tsmiPedidoParcial,
            this.tsmiPedidoKO});
            this.tsmiCambiarEstadoPedido.Image = global::albartohnosDesktop.Properties.Resources.Copy_6524;
            this.tsmiCambiarEstadoPedido.Name = "tsmiCambiarEstadoPedido";
            this.tsmiCambiarEstadoPedido.Size = new System.Drawing.Size(180, 22);
            this.tsmiCambiarEstadoPedido.Text = "Estados";
            // 
            // tsmiPedidoOK
            // 
            this.tsmiPedidoOK.Image = global::albartohnosDesktop.Properties.Resources.Redo_16x;
            this.tsmiPedidoOK.Name = "tsmiPedidoOK";
            this.tsmiPedidoOK.Size = new System.Drawing.Size(180, 22);
            this.tsmiPedidoOK.Text = "Cambiar a OK";
            this.tsmiPedidoOK.Click += new System.EventHandler(this.tsmiPedidoOK_Click);
            // 
            // tsmiPedidoParcial
            // 
            this.tsmiPedidoParcial.Image = global::albartohnosDesktop.Properties.Resources.Redo_16x;
            this.tsmiPedidoParcial.Name = "tsmiPedidoParcial";
            this.tsmiPedidoParcial.Size = new System.Drawing.Size(180, 22);
            this.tsmiPedidoParcial.Text = "Cambiar a Parcial";
            this.tsmiPedidoParcial.Click += new System.EventHandler(this.tsmiPedidoParcial_Click);
            // 
            // tsmiPedidoKO
            // 
            this.tsmiPedidoKO.Image = global::albartohnosDesktop.Properties.Resources.Redo_16x;
            this.tsmiPedidoKO.Name = "tsmiPedidoKO";
            this.tsmiPedidoKO.Size = new System.Drawing.Size(180, 22);
            this.tsmiPedidoKO.Text = "Cambiar a KO";
            this.tsmiPedidoKO.Click += new System.EventHandler(this.tsmiPedidoKO_Click);
            // 
            // tsmiEliminarPedido
            // 
            this.tsmiEliminarPedido.Image = global::albartohnosDesktop.Properties.Resources.action_Cancel_16xMD;
            this.tsmiEliminarPedido.Name = "tsmiEliminarPedido";
            this.tsmiEliminarPedido.Size = new System.Drawing.Size(180, 22);
            this.tsmiEliminarPedido.Text = "Eliminar";
            this.tsmiEliminarPedido.Click += new System.EventHandler(this.tsmiEliminarPedido_Click);
            // 
            // chPrecio
            // 
            this.chPrecio.Text = "Precio";
            this.chPrecio.Width = 129;
            // 
            // PedidosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.btnUpdateOrders);
            this.Controls.Add(this.btnCreateOrders);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PedidosFRM";
            this.Text = "PedidosFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PedidosFRM_FormClosed);
            this.cmsMenuOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateOrders;
        private System.Windows.Forms.Button btnCreateOrders;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader chCodPedido;
        private System.Windows.Forms.ColumnHeader chProducto;
        private System.Windows.Forms.ColumnHeader chTipo;
        private System.Windows.Forms.ColumnHeader chEstado;
        private System.Windows.Forms.ColumnHeader chCantidad;
        private System.Windows.Forms.ContextMenuStrip cmsMenuOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarPedido;
        private System.Windows.Forms.ToolStripMenuItem tsmiCambiarEstadoPedido;
        private System.Windows.Forms.ToolStripMenuItem tsmiPedidoOK;
        private System.Windows.Forms.ToolStripMenuItem tsmiPedidoParcial;
        private System.Windows.Forms.ToolStripMenuItem tsmiPedidoKO;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarPedido;
        private System.Windows.Forms.ColumnHeader chPrecio;
    }
}