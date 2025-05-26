namespace albartohnosDesktop.ListFRM
{
    partial class StockFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockFRM));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvStock = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMenuStock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarStock = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnCreateStock = new System.Windows.Forms.Button();
            this.cmsMenuStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Stock de -";
            // 
            // lvStock
            // 
            this.lvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNombre,
            this.chCantidad});
            this.lvStock.ContextMenuStrip = this.cmsMenuStock;
            this.lvStock.FullRowSelect = true;
            this.lvStock.GridLines = true;
            this.lvStock.HideSelection = false;
            this.lvStock.Location = new System.Drawing.Point(12, 48);
            this.lvStock.Name = "lvStock";
            this.lvStock.Size = new System.Drawing.Size(1038, 265);
            this.lvStock.TabIndex = 10;
            this.lvStock.UseCompatibleStateImageBehavior = false;
            this.lvStock.View = System.Windows.Forms.View.Details;
            this.lvStock.SelectedIndexChanged += new System.EventHandler(this.lvStock_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 88;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 403;
            // 
            // chCantidad
            // 
            this.chCantidad.Text = "Cantidad";
            this.chCantidad.Width = 107;
            // 
            // cmsMenuStock
            // 
            this.cmsMenuStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditStock,
            this.tsmiEliminarStock});
            this.cmsMenuStock.Name = "cmsMenuWh";
            this.cmsMenuStock.Size = new System.Drawing.Size(118, 48);
            this.cmsMenuStock.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuStock_Opening);
            // 
            // tsmiEditStock
            // 
            this.tsmiEditStock.Image = global::albartohnosDesktop.Properties.Resources.action_Edit_16xMD;
            this.tsmiEditStock.Name = "tsmiEditStock";
            this.tsmiEditStock.Size = new System.Drawing.Size(117, 22);
            this.tsmiEditStock.Text = "Editar";
            this.tsmiEditStock.Click += new System.EventHandler(this.tsmiEditStock_Click);
            // 
            // tsmiEliminarStock
            // 
            this.tsmiEliminarStock.Image = global::albartohnosDesktop.Properties.Resources.action_Cancel_16xMD;
            this.tsmiEliminarStock.Name = "tsmiEliminarStock";
            this.tsmiEliminarStock.Size = new System.Drawing.Size(117, 22);
            this.tsmiEliminarStock.Text = "Eliminar";
            this.tsmiEliminarStock.Click += new System.EventHandler(this.tsmiEliminarStock_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Image = global::albartohnosDesktop.Properties.Resources.action_reload_16xMD;
            this.btnUpdateStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStock.Location = new System.Drawing.Point(771, 14);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateStock.TabIndex = 13;
            this.btnUpdateStock.Text = "Actualizar Lista";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnCreateStock
            // 
            this.btnCreateStock.Image = global::albartohnosDesktop.Properties.Resources.action_add_16xMD;
            this.btnCreateStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateStock.Location = new System.Drawing.Point(913, 14);
            this.btnCreateStock.Name = "btnCreateStock";
            this.btnCreateStock.Size = new System.Drawing.Size(136, 23);
            this.btnCreateStock.TabIndex = 12;
            this.btnCreateStock.Text = "Crear Stock";
            this.btnCreateStock.UseVisualStyleBackColor = true;
            this.btnCreateStock.Click += new System.EventHandler(this.btnCreateStock_Click);
            // 
            // StockFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1062, 328);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnCreateStock);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StockFRM";
            this.Text = "StockFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockFRM_FormClosed);
            this.cmsMenuStock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnCreateStock;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvStock;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chCantidad;
        private System.Windows.Forms.ContextMenuStrip cmsMenuStock;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditStock;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarStock;
    }
}