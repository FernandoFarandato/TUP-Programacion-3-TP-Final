using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ProveedorDB
    {

        public static void crearProveedor(string nombre, int es_minorista, string dni, string porcentage_ganancia, string cuit, string ibb)
        {
            string querry = $"INSERT INTO proveedores (nombre, es_minorista, dni, porcentage_ganancia, cuit, ibb) VALUES ('{nombre}', '{es_minorista}', '{dni}', '{porcentage_ganancia}', '{cuit}', '{ibb}')";

            MySqlConnection conexionBD = ConexionDB.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Proveedor guardado correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar proveedor {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
            }
        }



    }
}
