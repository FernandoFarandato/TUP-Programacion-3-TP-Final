using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class DireccionDB
    {

        public static void crearDireccion(
            string calle,
            string numero,
            string cuidad,
            string provincia,
            int proveedores_id)
        {
            string querry = $"INSERT INTO direcciones (calle, numero, cuidad, provincia, proveedores_id) VALUES ('{calle}', '{numero}', '{cuidad}', '{provincia}', '{proveedores_id}')";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Direccion guardada correctamente");
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

        public static void eliminarDireccion(int proveedores_id)
        {
            string querry = $"DELETE from direcciones WHERE proveedores_id = '{proveedores_id}';";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Direccion Eliminada");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar la Direccion {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

        public static void updateDireccion(
            string calle,
            string numero,
            string cuidad,
            string provincia,
            int proveedores_id)
        {

            string querry = $"UPDATE direcciones SET calle  = '{calle}', numero  = '{numero}', cuidad = '{cuidad}', provincia = '{provincia}' WHERE proveedores_id = '{proveedores_id}'";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Direccion Actualizada");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al actualizar el Direccion {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }

        }


    }
}
