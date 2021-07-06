using System;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class Frm_marcas : Form
    {

        ToolStripMenuItem toolStrimMenuItem;

        public Frm_marcas(ref ToolStripMenuItem menuItem)
        {
            InitializeComponent();
            toolStrimMenuItem = menuItem;
            dgv_marcas.DataSource = Marca.traerMarcas();
        }

        // Botones ---------------------------------------------------
        //Boton Guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (rb_guardar.Checked)
            {
                //Datos Marca.
                string nombre = txt_nombre.Text;
                string descripcion = txt_descripcion.Text;

                Marca marca = new Marca(nombre, descripcion);
                marca.crearMarca();

                limpiar_txt_boxs();
                dgv_marcas.DataSource = Marca.traerMarcas();
            }
        }
        //Boton Actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (rb_actualizar.Checked)
            {
                //Datos Marca.
                int id = Int32.Parse(txt_id.Text);
                string nombre = txt_nombre.Text;
                string descripcion = txt_descripcion.Text;

                Marca marca = new Marca(id, nombre, descripcion);
                marca.updateMarca();

                limpiar_txt_boxs();
                dgv_marcas.DataSource = Marca.traerMarcas();
            }
        }
        //Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (rb_eliminar.Checked)
            {
                int id = Int32.Parse(txt_id.Text);

                Marca marca = new Marca(id);
                marca.eliminarMarca();

                limpiar_txt_boxs();
                dgv_marcas.DataSource = Marca.traerMarcas();
            }
        }

        //Boton Limpiar TextBoxs
        private void btn_limpiar_datos_Click(object sender, EventArgs e)
        {
            limpiar_txt_boxs();
        }

        //Boton Salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            toolStrimMenuItem.Enabled = true;
            this.Close();
        }

        // Radio Buttons ---------------------------------------------
        //Radio Button Guardar
        private void rb_guardar_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_guardar.Checked)
            {
                txt_id.Enabled = false;
                txt_nombre.Enabled = true;
                txt_descripcion.Enabled = true;
            }
        }
        //Radio Button Eliminar
        private void rb_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = true;
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
        }
        //Radio Button Actualizar
        private void rb_actualizar_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;
        }

        // Funciones ---------------------------------------------------

        //Limpiar campos de texto
        private void limpiar_txt_boxs()
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
        }

        private void cargarDatosDeTabla()
        {

            limpiar_txt_boxs();

            //Tomo Datos de DataTable

            //Datos Marca
            int id = Int32.Parse(Convert.ToString(this.dgv_marcas.CurrentRow.Cells["id"].Value));
            string nombre = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["nombre_marca"].Value);
            string descripcion = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["descripcion_marca"].Value);

            //Los paso a los text_boxs

            txt_id.Text = id.ToString();
            txt_nombre.Text = nombre;
            txt_descripcion.Text = descripcion;
        }

        // Otros ---------------------------------------------------
        private void dgv_marcas_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cargarDatosDeTabla();
        }

    }
}
