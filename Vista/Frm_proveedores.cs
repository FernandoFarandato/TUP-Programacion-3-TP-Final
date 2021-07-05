using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Frm_proveedores : Form
    {
        ToolStripMenuItem cambiarHabilitacion;

        public Frm_proveedores(ref ToolStripMenuItem valor)
        {
            cambiarHabilitacion = valor;
            InitializeComponent();
        }

        private void frmProveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            cambiarHabilitacion.Enabled = true;
        }

        private void btoLimpiar_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_cuidad.Text = "";
            txt_provincia.Text = "";
            txt_calle.Text = "";
            txt_numero.Text = "";
            txt_telefono.Text = "";
            //celularProveedor.Text = "";
            txt_dni.Text = "";
            txt_cuit.Text = "";
            txt_ibb.Text = "";
        }

        private void Frm_proveedores_Load(object sender, EventArgs e)
        {

        }


    }
}
