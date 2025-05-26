namespace albartohnosDesktop.ListFRM
{
    partial class ProductosFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosFRM));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.chSku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiVerStockProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActivarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesactivarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateProducts = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.cmsMenuProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Listado de Productos";
            // 
            // lvProducts
            // 
            this.lvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSku,
            this.chNombre,
            this.chActivo,
            this.chDescripcion});
            this.lvProducts.ContextMenuStrip = this.cmsMenuProduct;
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(12, 41);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(611, 265);
            this.lvProducts.TabIndex = 6;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
            // 
            // chSku
            // 
            this.chSku.Text = "SKU";
            this.chSku.Width = 88;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 128;
            // 
            // chActivo
            // 
            this.chActivo.Text = "Activo";
            this.chActivo.Width = 54;
            // 
            // chDescripcion
            // 
            this.chDescripcion.Text = "Descripción";
            this.chDescripcion.Width = 324;
            // 
            // cmsMenuProduct
            // 
            this.cmsMenuProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerStockProducto,
            this.tsmiEditarProducto,
            this.tsmiActivarProducto,
            this.tsmiDesactivarProducto,
            this.tsmiEliminarProducto});
            this.cmsMenuProduct.Name = "cmsMenuVehicle";
            this.cmsMenuProduct.Size = new System.Drawing.Size(129, 114);
            this.cmsMenuProduct.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuProduct_Opening);
            // 
            // tsmiVerStockProducto
            // 
            this.tsmiVerStockProducto.Image = global::albartohnosDesktop.Properties.Resources.procedure_16xMD;
            this.tsmiVerStockProducto.Name = "tsmiVerStockProducto";
            this.tsmiVerStockProducto.Size = new System.Drawing.Size(128, 22);
            this.tsmiVerStockProducto.Text = "Ver Stock";
            this.tsmiVerStockProducto.Click += new System.EventHandler(this.tsmiVerStockProducto_Click);
            // 
            // tsmiEditarProducto
            // 
            this.tsmiEditarProducto.Image = global::albartohnosDesktop.Properties.Resources.action_Edit_16xMD;
            this.tsmiEditarProducto.Name = "tsmiEditarProducto";
            this.tsmiEditarProducto.Size = new System.Drawing.Size(128, 22);
            this.tsmiEditarProducto.Text = "Editar";
            this.tsmiEditarProducto.Click += new System.EventHandler(this.tsmiEditarProducto_Click);
            // 
            // tsmiActivarProducto
            // 
            this.tsmiActivarProducto.Image = global::albartohnosDesktop.Properties.Resources.CheckBox_669;
            this.tsmiActivarProducto.Name = "tsmiActivarProducto";
            this.tsmiActivarProducto.Size = new System.Drawing.Size(128, 22);
            this.tsmiActivarProducto.Text = "Activar";
            this.tsmiActivarProducto.Click += new System.EventHandler(this.tsmiActivarProducto_Click);
            // 
            // tsmiDesactivarProducto
            // 
            this.tsmiDesactivarProducto.Image = global::albartohnosDesktop.Properties.Resources.CheckBox_669;
            this.tsmiDesactivarProducto.Name = "tsmiDesactivarProducto";
            this.tsmiDesactivarProducto.Size = new System.Drawing.Size(128, 22);
            this.tsmiDesactivarProducto.Text = "Desactivar";
            this.tsmiDesactivarProducto.Click += new System.EventHandler(this.tsmiDesactivarProducto_Click);
            // 
            // tsmiEliminarProducto
            // 
            this.tsmiEliminarProducto.Image = global::albartohnosDesktop.Properties.Resources.action_Cancel_16xMD;
            this.tsmiEliminarProducto.Name = "tsmiEliminarProducto";
            this.tsmiEliminarProducto.Size = new System.Drawing.Size(128, 22);
            this.tsmiEliminarProducto.Text = "Eliminar";
            this.tsmiEliminarProducto.Click += new System.EventHandler(this.tsmiEliminarProducto_Click);
            // 
            // btnUpdateProducts
            // 
            this.btnUpdateProducts.Image = global::albartohnosDesktop.Properties.Resources.action_reload_16xMD;
            this.btnUpdateProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProducts.Location = new System.Drawing.Point(345, 12);
            this.btnUpdateProducts.Name = "btnUpdateProducts";
            this.btnUpdateProducts.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateProducts.TabIndex = 9;
            this.btnUpdateProducts.Text = "Actualizar Lista";
            this.btnUpdateProducts.UseVisualStyleBackColor = true;
            this.btnUpdateProducts.Click += new System.EventHandler(this.btnUpdateProducts_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Image = global::albartohnosDesktop.Properties.Resources.action_add_16xMD;
            this.btnCreateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateProduct.Location = new System.Drawing.Point(487, 12);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(136, 23);
            this.btnCreateProduct.TabIndex = 8;
            this.btnCreateProduct.Text = "Crear Producto";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // ProductosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(635, 328);
            this.Controls.Add(this.btnUpdateProducts);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductosFRM";
            this.Text = "ProductosFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductosFRM_FormClosed);
            this.cmsMenuProduct.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProducts;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader chSku;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chDescripcion;
        private System.Windows.Forms.ColumnHeader chActivo;
        private System.Windows.Forms.ContextMenuStrip cmsMenuProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivarProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesactivarProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerStockProducto;
    }
}