using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Modelo
{
    public class MarcaDB
    {
        public static void crearMarca(string nombre_marca, string descripcion_marca)
        {
            string querry = $"INSERT INTO marcas (nombre_marca, descripcion_marca) VALUES ('{nombre_marca}', '{descripcion_marca}')";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Marca guardada correctamente");
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

        public static void eliminarMarca(int id)
        {
            string querry = $"DELETE from marcas WHERE id_marcas = '{id}';";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Marca Eliminado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar Marca {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

        public static DataTable traerMarcas()
        {
            string querry = $"SELECT m.id_marcas, m.nombre_marca, m.descripcion_marca FROM marcas AS m";

            DataTable dataTableMarcas = new DataTable("marcas");
            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();

                MySqlDataAdapter dataReader = new MySqlDataAdapter(comando);
                dataReader.Fill(dataTableMarcas);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al cargar marcas del servidor {ex.Message}");
                dataTableMarcas = null;
            }
            finally
            {
                conexionDB.Close();
            }

            return dataTableMarcas;
        }

        public static void updateMarca( int id,string nombre_marca, string descripcion_marca)
        {
            string querry = $"UPDATE marcas SET  nombre_marca  = '{nombre_marca}', descripcion_marca  = '{descripcion_marca}' WHERE id_marcas = '{id}'";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor Actualizado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al actualizar el Proveedor {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }
    }
}
