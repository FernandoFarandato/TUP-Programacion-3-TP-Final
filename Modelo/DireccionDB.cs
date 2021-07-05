using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

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

            MySqlConnection conexionBD = Conexion.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Direccion guardado correctamente");
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

        public static void eliminarDireccion(int id)
        {
            string querry = $"DELETE from direcciones WHERE proveedores_id = '{id}'";

            MySqlConnection conexionBD = Conexion.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor Eliminado Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
            }
        }

    }
}
