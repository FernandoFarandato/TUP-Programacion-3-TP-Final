using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace Vista
{
    public partial class Frm_Productos : Form
    {

        ToolStripMenuItem toolStrimMenuItem;

        public Frm_Productos(ref ToolStripMenuItem menuItem)
        {
            InitializeComponent();
            toolStrimMenuItem = menuItem;
            //dgv_marcas.DataSource = Marca.traerMarcas();
            dgv_productos.DataSource = Producto.traerProductos_Precio_NombreMarca_NombrePorveedor();
        }

        // Botones ---------------------------------------------------

        //Boton Guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
        //Boton Actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }
        //Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

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
                txt_precio.Enabled = true;
            }
        }

        //Radio Button Actualizar
        private void rb_actualizar_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;
            txt_precio.Enabled = true;
        }
        //Radio Button Eliminar
        private void rb_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = true;
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            txt_precio.Enabled = false;
        }



        // Funciones ---------------------------------------------------

        //Limpiar campos de texto
        private void limpiar_txt_boxs()
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_precio.Text = "";
        }

        private void cargarDatosDeTablaMarca()
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

        private void cargarDatosDeTablaProductos()
        {

            limpiar_txt_boxs();

            //Tomo Datos de DataTable

            //Datos Marca
            int id = Int32.Parse(Convert.ToString(this.dgv_productos.CurrentRow.Cells["id"].Value));
            string nombre = Convert.ToString(this.dgv_productos.CurrentRow.Cells["nombre_productos"].Value);
            string descripcion = Convert.ToString(this.dgv_productos.CurrentRow.Cells["descripcion_productos"].Value);
            string precio = Convert.ToString(this.dgv_productos.CurrentRow.Cells["precio"].Value);

            //Los paso a los text_boxs

            txt_id.Text = id.ToString();
            txt_nombre.Text = nombre;
            txt_descripcion.Text = descripcion;
            txt_precio.Text = precio;
        }

        // Otros ---------------------------------------------------
        private void dgv_marcas_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cargarDatosDeTablaMarca();
        }

        private void dgb_productos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cargarDatosDeTablaProductos();
        }


    }
}
