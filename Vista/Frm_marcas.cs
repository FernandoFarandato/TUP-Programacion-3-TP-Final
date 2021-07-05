using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Vista
{
    public partial class Frm_marcas : Form
    {

        ToolStripMenuItem marcasToolStripMenuItem;

        public Frm_marcas(ref ToolStripMenuItem menuItem)
        {
            InitializeComponent();
            marcasToolStripMenuItem = menuItem;
            //dgv_proveedores.DataSource = Proveedor.obtenerProveedoresYDireccionYTelefono();
        }


        //  Botones -----------------------------------------------------------------

        //Borrar datos en los formularios
        private void btn_limpiar_datos_Click(object sender, EventArgs e)
        {
            borrar_txt_labels();
        }

        //Boton Salir del Formulario
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  Radio Buttons -----------------------------------------------------------------

        //Radio Button Control - Guardar
        private void rb_guardar_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_guardar.Checked) txt_id.Enabled = false;
            else txt_id.Enabled = true;
        }

        //Radio Button Control - Eliminar
        private void rb_eliminar_CheckedChanged(object sender, EventArgs e)
        {

            if (rb_eliminar.Checked)
            {

                txt_id.Enabled = true;
                txt_nombre.Enabled = true;
                txt_cuidad.Enabled = true;

                Utils.messageWarning(this, "Elimnar Activado");
            }
            else
            {
                txt_id.Enabled = true;
                txt_nombre.Enabled = true;
                txt_cuidad.Enabled = true;
 
                Utils.messageWarning(this, "Elimnar Desactivado");
            }

        }

        //Radio Button Control - Actualizar
        private void rb_actualizar_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = true;
            lbl_id.Enabled = true;
        }

        //  Funciones -----------------------------------------------------------------

        // Limpiar texto de text_labels
        private void borrar_txt_labels()
        {

            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_cuidad.Text = "";

        }
    }
}
