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


namespace Vista
{
    public partial class Frm_Productos : Form
    {

        ToolStripMenuItem toolStrimMenuItem;

        public Frm_Productos(ref ToolStripMenuItem menuItem)
        {
            InitializeComponent();
            toolStrimMenuItem = menuItem;
            dgv_productos.DataSource = Producto.traerProductos_Precio_NombreMarca_NombrePorveedor();
            dgv_proveedores.DataSource = Proveedor.traerProveedores_Nombre();
            dgv_marcas.DataSource = Marca.traerMarcas();
        }

        // Botones ---------------------------------------------------

        //Boton Guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (rb_guardar.Checked)
            {
                //Datos Producto.
                string nombre = txt_nombre.Text;
                string descripcion = txt_descripcion.Text;
                int marcas_id = Int32.Parse(txt_marcas_id.Text);
                int id_proveedor = Int32.Parse(txt_proveedores_id.Text);

                //Datos precio
                string precio = txt_precio.Text;

                //creo un objeto producto sin id pq lo genera la base de datos
                Producto producto = new Producto(nombre, descripcion, marcas_id, id_proveedor);
                producto.crearProducto();
                //Traigo el id de la base de datos
                int id_producto = producto.traerID();
                Precio costo = new Precio(precio, id_producto);
                costo.crearPrecio();

                //creo un producto con el id que busque de la base de datos
                Producto producto1 = new Producto(id_producto, nombre, descripcion, marcas_id, id_proveedor);
                //Con ambos id creo la relacion
                producto1.crearRelacionProductoProveedor();

                limpiar_txt_boxs();
                dgv_productos.DataSource = Producto.traerProductos_Precio_NombreMarca_NombrePorveedor();

            }
        }
        //Boton Actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (rb_actualizar.Checked)
            {
                //Datos Producto.
                int id = Int32.Parse(txt_id.Text);
                string nombre = txt_nombre.Text;
                string descripcion = txt_descripcion.Text;
                int marcas_id = Int32.Parse(txt_marcas_id.Text);
                int id_proveedor = 0;

                //Datos precio
                string precio = txt_precio.Text;

                Producto producto = new Producto(id, nombre, descripcion, marcas_id, id_proveedor);
                producto.updateProducto();

                limpiar_txt_boxs();
                dgv_productos.DataSource = Producto.traerProductos_Precio_NombreMarca_NombrePorveedor();
            }
        }
        //Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (rb_eliminar.Checked)
            {
                int id = Int32.Parse(txt_id.Text);
                string nombreProveedor = Convert.ToString(this.dgv_productos.CurrentRow.Cells["nombre"].Value);
                int id_proveedor = Proveedor.traerIDviaProducto(nombreProveedor, id);
                Precio.eliminarPrecio(id);

                Producto producto = new Producto(id, id_proveedor);
                producto.eliminarRelacionProductoProveedor();
                producto.eliminarProducto();

                limpiar_txt_boxs();
                dgv_productos.DataSource = Producto.traerProductos_Precio_NombreMarca_NombrePorveedor();
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
            //Tomo Datos de DataTable

            //Datos Marca
            int id = Int32.Parse(Convert.ToString(this.dgv_marcas.CurrentRow.Cells["id_marcas"].Value));

            //Los paso a los text_boxs
            txt_marcas_id.Text = id.ToString();
        }

        private void cargarDatosDeTablaProductos()
        {
            //Tomo Datos de DataTable

            //Datos Marca
            int id = Int32.Parse(Convert.ToString(this.dgv_productos.CurrentRow.Cells["id_productos"].Value));
            string nombre = Convert.ToString(this.dgv_productos.CurrentRow.Cells["nombre_productos"].Value);
            string descripcion = Convert.ToString(this.dgv_productos.CurrentRow.Cells["descripcion_productos"].Value);
            string precio = Convert.ToString(this.dgv_productos.CurrentRow.Cells["precio"].Value);

            //Los paso a los text_boxs

            txt_id.Text = id.ToString();
            txt_nombre.Text = nombre;
            txt_descripcion.Text = descripcion;
            txt_precio.Text = precio;
        }

        private void cargarDatosDeTablaProveedor()
        {
            //Tomo Datos de DataTable

            //Datos Proveedor
            int id = Int32.Parse(Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["id"].Value));

            //Los paso a los text_boxs
            txt_proveedores_id.Text = id.ToString();
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

        private void dgv_proveedores_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cargarDatosDeTablaProveedor();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
