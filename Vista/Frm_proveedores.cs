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
using Controlador;


namespace Vista
{
    public partial class Frm_proveedores : Form
    {
        ToolStripMenuItem toolStrimMenuItem;

        public Frm_proveedores(ref ToolStripMenuItem menuItem)
        {
            InitializeComponent();
            toolStrimMenuItem = menuItem;
            dgv_proveedores.DataSource = Proveedor.traerProveedores_Direccion_Telefono();
            
        }


        // Botones ---------------------------------------------------

        //Boton Guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (rb_guardar.Checked)
            {
                //Datos Proveedor.
                int id;
                string nombre = txt_nombre.Text;
                int es_minorista = 0;
                string dni = txt_dni.Text;
                string porcentage_ganancia = txt_porcentage_ganancia.Text;
                string cuit = txt_cuit.Text;
                string ibb = txt_ibb.Text;

                //Datos Direccion.
                string calle = txt_calle.Text;
                string numero = txt_numero.Text;
                string cuidad = txt_cuidad.Text;
                string provincia = txt_provincia.Text;
                
                //Datos Telefono
                string telefono = txt_telefono.Text;

                if (rb_minorista.Checked) { 
                    es_minorista = 1;
                    porcentage_ganancia = "5";
                }
                if (rb_mayorista.Checked) es_minorista = 0;

                Proveedor proveedor = new Proveedor(nombre, es_minorista, porcentage_ganancia, dni, cuit, ibb);
                proveedor.crearProveedor();
                id = proveedor.traerID();
                Direccion direccion = new Direccion(calle, numero, cuidad, provincia, id);
                direccion.crearDireccion();
                Telefono telefono_obj = new Telefono(telefono, id);
                telefono_obj.crearTelefono();

                limpiar_txt_boxs();
                dgv_proveedores.DataSource = Proveedor.traerProveedores_Direccion_Telefono();
            }
        }
        //Boton Actualizar

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (rb_actualizar.Checked)
            {
                //Datos Proveedor.
                int id = Int32.Parse(txt_id.Text);
                string nombre = txt_nombre.Text;
                int es_minorista = 0;
                string dni = txt_dni.Text;
                string porcentage_ganancia = txt_porcentage_ganancia.Text;
                string cuit = txt_cuit.Text;
                string ibb = txt_ibb.Text;

                //Datos Direccion.
                string calle = txt_calle.Text;
                string numero = txt_numero.Text;
                string cuidad = txt_cuidad.Text;
                string provincia = txt_provincia.Text;

                //Datos Telefono
                string numero_contacto = txt_telefono.Text;

                if (rb_minorista.Checked)
                {
                    es_minorista = 1;
                    porcentage_ganancia = "5";
                }
                if (rb_mayorista.Checked) es_minorista = 0;

                Proveedor proveedor = new Proveedor(id, nombre, es_minorista, porcentage_ganancia ,dni, cuit, ibb);
                proveedor.updateProveedor();
                Direccion direccion = new Direccion(calle, numero, cuidad, provincia, id);
                direccion.updateDireccion();
                Telefono telefono = new Telefono(numero_contacto, id);
                telefono.updateTelefono();

                limpiar_txt_boxs();
                dgv_proveedores.DataSource = Proveedor.traerProveedores_Direccion_Telefono();
            }
        }

        //Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (rb_eliminar.Checked)
            {
                int id = Int32.Parse(txt_id.Text);

                Direccion direccion = new Direccion(id);
                Telefono telefono = new Telefono(id);
                Proveedor proveedor = new Proveedor(id);
                
                direccion.eliminarDireccion();
                telefono.eliminarTelefono();
                proveedor.eliminarProveedor();
                
                limpiar_txt_boxs();
                dgv_proveedores.DataSource = Proveedor.traerProveedores_Direccion_Telefono();
            }
        }

        //Boton Salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            toolStrimMenuItem.Enabled = true;
            this.Close();
        }

        //Boton Limpiar Datos
        private void btn_limpiar_datos_Click(object sender, EventArgs e)
        {
            limpiar_txt_boxs();
        }
        // Radio Buttons ---------------------------------------------

        //Radio Button Minorsita
        private void rb_minorista_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_minorista.Checked)
            {
                gb_minorista.Enabled = true;
                gb_mayorista.Enabled = false;

                txt_cuit.Text = "";
                txt_ibb.Text = "";
                txt_porcentage_ganancia.Text = "";


            }
            else
            {
                gb_minorista.Enabled = false;
                gb_mayorista.Enabled = true;
            }
        }
        //Radio Button Mayorista
        private void rb_mayorista_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_mayorista.Checked)
            {
                gb_mayorista.Enabled = true;
                gb_minorista.Enabled = false;
                txt_dni.Text = "";

            }
            else
            {
                gb_mayorista.Enabled = false;
                gb_minorista.Enabled = true;
            }
        }
        //Radio Button Guardar
        private void rb_guardar_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_nombre.Enabled = true;
            txt_cuidad.Enabled = true;
            txt_provincia.Enabled = true;
            txt_calle.Enabled = true;
            txt_numero.Enabled = true;
            txt_telefono.Enabled = true;

        }
        //Radio Button Eliminar
        private void rb_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = true;
            txt_nombre.Enabled = false;
            txt_cuidad.Enabled = false;
            txt_provincia.Enabled = false;
            txt_calle.Enabled = false;
            txt_numero.Enabled = false;
            txt_telefono.Enabled = false;
        }
        //Radio Button Actualizar
        private void rb_actualizar_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_nombre.Enabled = true;
            txt_cuidad.Enabled = true;
            txt_provincia.Enabled = true;
            txt_calle.Enabled = true;
            txt_numero.Enabled = true;
            txt_telefono.Enabled = true;
        }


        // Funciones ---------------------------------------------------

        //Limpiar campos de texto
        private void limpiar_txt_boxs()
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_cuidad.Text = "";
            txt_provincia.Text = "";
            txt_calle.Text = "";
            txt_numero.Text = "";
            txt_telefono.Text = "";
            txt_dni.Text = "";
            txt_cuit.Text = "";
            txt_ibb.Text = "";
            txt_porcentage_ganancia.Text = "";
        }

        private void cargarDatosDeTabla()
        {

            limpiar_txt_boxs();

            //Tomo Datos de DataTable

            //Datos Proveedor
            int id = Int32.Parse(Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["id"].Value));
            string nombre = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["nombre"].Value);
            //int es_minorista = 
            string dni = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["dni"].Value);
            string porcentage_ganancia = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["porcentage_ganancia"].Value);
            string cuit = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["cuit"].Value);
            string ibb = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["ibb"].Value);

            //Datos Direccion
            string calle = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["calle"].Value);
            string numero = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["numero"].Value);
            string cuidad = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["cuidad"].Value);
            string provincia = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["provincia"].Value);

            //Datos Telefono
            string telefono = Convert.ToString(this.dgv_proveedores.CurrentRow.Cells["numero_contacto"].Value);

            //Los paso a los text_boxs

            txt_id.Text = id.ToString();
            txt_nombre.Text = nombre;
            txt_dni.Text = dni;
            txt_porcentage_ganancia.Text = porcentage_ganancia;
            txt_cuit.Text = cuit;
            txt_ibb.Text = ibb;

            txt_calle.Text = calle;
            txt_numero.Text = numero;
            txt_cuidad.Text = cuidad;
            txt_provincia.Text = provincia;
            
            txt_telefono.Text = telefono;
        }

        // Otros ---------------------------------------------------
        private void Frm_proveedores_Load(object sender, EventArgs e)
        {
            limpiar_txt_boxs();
        }
        private void Frm_proveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            toolStrimMenuItem.Enabled = true;
        }

        private void dgv_proveedores_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cargarDatosDeTabla();
        }


    }
}
