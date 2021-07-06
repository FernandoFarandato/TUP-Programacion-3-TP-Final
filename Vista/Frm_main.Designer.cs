
namespace Vista
{
    partial class Frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_marca = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_proveedores,
            this.ToolStripMenuItem_marca,
            this.ToolStripMenuItem_productos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_proveedores
            // 
            this.ToolStripMenuItem_proveedores.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ToolStripMenuItem_proveedores.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_proveedores.Name = "ToolStripMenuItem_proveedores";
            this.ToolStripMenuItem_proveedores.Size = new System.Drawing.Size(103, 24);
            this.ToolStripMenuItem_proveedores.Text = "Proveedores";
            this.ToolStripMenuItem_proveedores.Click += new System.EventHandler(this.ToolStripMenuItem_proveedores_Click);
            // 
            // ToolStripMenuItem_marca
            // 
            this.ToolStripMenuItem_marca.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ToolStripMenuItem_marca.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_marca.Name = "ToolStripMenuItem_marca";
            this.ToolStripMenuItem_marca.Size = new System.Drawing.Size(68, 24);
            this.ToolStripMenuItem_marca.Text = "Marcas";
            this.ToolStripMenuItem_marca.Click += new System.EventHandler(this.ToolStripMenuItem_marca_Click);
            // 
            // ToolStripMenuItem_productos
            // 
            this.ToolStripMenuItem_productos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ToolStripMenuItem_productos.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_productos.Name = "ToolStripMenuItem_productos";
            this.ToolStripMenuItem_productos.Size = new System.Drawing.Size(87, 24);
            this.ToolStripMenuItem_productos.Text = "Productos";
            this.ToolStripMenuItem_productos.Click += new System.EventHandler(this.ToolStripMenuItem_productos_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_productos;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_proveedores;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_marca;
    }
}