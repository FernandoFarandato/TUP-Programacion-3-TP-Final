
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_marca = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_proveedores,
            this.ToolStripMenuItem_marca,
            this.ToolStripMenuItem_productos,
            this.ToolStripMenuItem_usuarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_proveedores
            // 
            this.ToolStripMenuItem_proveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMProveedoresToolStripMenuItem});
            this.ToolStripMenuItem_proveedores.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ToolStripMenuItem_proveedores.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_proveedores.Name = "ToolStripMenuItem_proveedores";
            this.ToolStripMenuItem_proveedores.Size = new System.Drawing.Size(103, 24);
            this.ToolStripMenuItem_proveedores.Text = "Proveedores";
            this.ToolStripMenuItem_proveedores.Click += new System.EventHandler(this.ToolStripMenuItem_proveedores_Click);
            // 
            // aBMProveedoresToolStripMenuItem
            // 
            this.aBMProveedoresToolStripMenuItem.Name = "aBMProveedoresToolStripMenuItem";
            this.aBMProveedoresToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.aBMProveedoresToolStripMenuItem.Text = "ABM-Proveedores";
            // 
            // ToolStripMenuItem_marca
            // 
            this.ToolStripMenuItem_marca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMMarcasToolStripMenuItem});
            this.ToolStripMenuItem_marca.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ToolStripMenuItem_marca.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_marca.Name = "ToolStripMenuItem_marca";
            this.ToolStripMenuItem_marca.Size = new System.Drawing.Size(68, 24);
            this.ToolStripMenuItem_marca.Text = "Marcas";
            this.ToolStripMenuItem_marca.Click += new System.EventHandler(this.ToolStripMenuItem_marca_Click);
            // 
            // aBMMarcasToolStripMenuItem
            // 
            this.aBMMarcasToolStripMenuItem.Name = "aBMMarcasToolStripMenuItem";
            this.aBMMarcasToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.aBMMarcasToolStripMenuItem.Text = "ABM-Marcas";
            // 
            // ToolStripMenuItem_productos
            // 
            this.ToolStripMenuItem_productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMProductosToolStripMenuItem});
            this.ToolStripMenuItem_productos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ToolStripMenuItem_productos.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_productos.Name = "ToolStripMenuItem_productos";
            this.ToolStripMenuItem_productos.Size = new System.Drawing.Size(87, 24);
            this.ToolStripMenuItem_productos.Text = "Productos";
            this.ToolStripMenuItem_productos.Click += new System.EventHandler(this.ToolStripMenuItem_productos_Click);
            // 
            // aBMProductosToolStripMenuItem
            // 
            this.aBMProductosToolStripMenuItem.Name = "aBMProductosToolStripMenuItem";
            this.aBMProductosToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.aBMProductosToolStripMenuItem.Text = "ABM-Productos";
            // 
            // ToolStripMenuItem_usuarios
            // 
            this.ToolStripMenuItem_usuarios.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ToolStripMenuItem_usuarios.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_usuarios.Name = "ToolStripMenuItem_usuarios";
            this.ToolStripMenuItem_usuarios.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItem_usuarios.Text = "Usuarios";
            this.ToolStripMenuItem_usuarios.Click += new System.EventHandler(this.ToolStripMenuItem_usuarios_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSistema_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_productos;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_proveedores;
        private System.Windows.Forms.ToolStripMenuItem aBMProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_marca;
        private System.Windows.Forms.ToolStripMenuItem aBMMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_usuarios;
    }
}