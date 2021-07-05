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
using Modelo;

namespace Vista
{
    public partial class Frm_proveedores : Form
    {
        ToolStripMenuItem toolStrimMenuItem;

        public Frm_proveedores(ref ToolStripMenuItem menuItem)
        {
            toolStrimMenuItem = menuItem;
            InitializeComponent();
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
            txt_id.Enabled = true;
            txt_nombre.Enabled = true;
            txt_cuidad.Enabled = true;
            txt_provincia.Enabled = true;
            txt_calle.Enabled = true;
            txt_numero.Enabled = true;
            txt_telefono.Enabled = true;
        }

        // Botones ---------------------------------------------------

        //Boton Guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (rb_guardar.Checked)
            {
                //Datos Proveedor.
                //int id = Int32.Parse(txt_id.Text);
                string nombre = txt_nombre.Text;
                int es_minorista = 0;
                string dni = txt_dni.Text;
                string porcentage_ganancia = txt_porcentage_ganancia.Text = "";
                string cuit = txt_cuit.Text;
                string ibb = txt_ibb.Text;

                //Datos Direccion.
                string calle = txt_calle.Text;
                string numero = txt_numero.Text;
                string cuidad = txt_cuidad.Text;
                string provinvia = txt_provincia.Text;
                
                //Datos Telefono
                string telefono = txt_telefono.Text;


                Proveedor proveedor = new Proveedor(nombre, es_minorista, dni, porcentage_ganancia, cuit, ibb);
                proveedor.crearProveedor();


                limpiar_txt_boxs();
            }
        }
        //Boton Actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        //Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

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

        // Otros ---------------------------------------------------
        private void Frm_proveedores_Load(object sender, EventArgs e)
        {
            limpiar_txt_boxs();
        }
        private void Frm_proveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            toolStrimMenuItem.Enabled = true;
        }
    }
}
