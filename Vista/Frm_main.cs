﻿using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Frm_main : Form
    {
        private string user;
        public Frm_main(string user)
        {
            InitializeComponent();
            this.user = user;
            this.Text = this.Text + " - User: " + user;
        }


        //Menus Barra de Navegacion.
        private void ToolStripMenuItem_proveedores_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_proveedores.Enabled = false;
            Frm_proveedores frm_proveedor = new Frm_proveedores(ref this.ToolStripMenuItem_proveedores);
            frm_proveedor.MdiParent = this;
            frm_proveedor.Show();
        }

        private void ToolStripMenuItem_marca_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_marca.Enabled = false;
            Frm_marcas frm_marcas = new Frm_marcas(ref this.ToolStripMenuItem_marca);
            frm_marcas.MdiParent = this;
            frm_marcas.Show();
        }

        private void ToolStripMenuItem_productos_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_usuarios_Click(object sender, EventArgs e)
        {

        }

        //Otros

        private void Frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}