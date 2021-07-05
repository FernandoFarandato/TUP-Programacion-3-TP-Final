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

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Proveedor guardado correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar proveedor {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

        public static void eliminarProveedor(int id)
        {
            string querry = $"DELETE from proveedores WHERE id = '{id}';";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor Eliminado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar Proveedor {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

    }
}
