using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Modelo
{
    public class PrecioDB
    {

        public static void crearPrecio(string precio, int productos_id)
        {
            string querry = $"INSERT INTO precio (precio, productos_id) VALUES ('{precio}', '{productos_id}')";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Precio guardado correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar marca {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

        public static void eliminarPrecio(int productos_id)
        {
            string querry = $"DELETE from precio WHERE productos_id = '{productos_id}';";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Precio Eliminado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar Precio {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

    }
}
