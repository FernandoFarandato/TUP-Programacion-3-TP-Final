using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Modelo
{
    public class ProveedorDB
    {
        public static void crearProveedor(
            string nombre,
            int es_minorista,
            string porcentage_ganancia,
            string dni,
            string cuit,
            string ibb)
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

        public static int traerID(string nombre, int es_minorista, string dni, string cuit)
        {

            int id = -1;
            string querry = $"SELECT id FROM proveedores WHERE nombre LIKE '{nombre}' AND es_minorista='{es_minorista}' AND dni LIKE '{dni}' AND cuit LIKE '{cuit}' LIMIT 1";

            MySqlDataReader dataReader = null;
            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                dataReader = comando.ExecuteReader();

                if (dataReader.Read())
                {
                    id = int.Parse(dataReader.GetString(0));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error al buscar ID{e.Message}");

            }
            finally
            {
                conexionDB.Close();
            }
            return id;
        }
   
        public static int traerIDviaProducto(string nombre, int id_producto)
        {
            int id = -1;
            string querry = $"SELECT id FROM proveedores AS p INNER JOIN proveedores_has_productos AS rel ON nombre LIKE '{nombre}' AND productos_id ='{id_producto}'";

            MySqlDataReader dataReader = null;
            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                dataReader = comando.ExecuteReader();

                if (dataReader.Read())
                {
                    id = int.Parse(dataReader.GetString(0));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error al buscar ID{e.Message}");

            }
            finally
            {
                conexionDB.Close();
            }
            return id;
        }

        public static DataTable traerProveedores_Direccion_Telefono()
        {
            string querry = $"SELECT p.id, p.nombre, p.dni, p.cuit, p.ibb, p.porcentage_ganancia, d.provincia, d.cuidad, d.calle, d.numero, t.numero_contacto FROM proveedores AS p INNER JOIN direcciones AS d INNER JOIN telefonos AS t ON t.proveedores_id=p.id AND d.proveedores_id=p.id";

            DataTable dataTableProveedores = new DataTable("proveedores");
            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();

                MySqlDataAdapter dataReader = new MySqlDataAdapter(comando);
                dataReader.Fill(dataTableProveedores);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al cargar proveedores del servidor {ex.Message}");
                dataTableProveedores = null;
            }
            finally
            {
                conexionDB.Close();
            }

            return dataTableProveedores;
        }

        public static DataTable traerProveedores_Nombre()
        {
            string querry = $"SELECT p.id, p.nombre FROM proveedores AS p";

            DataTable dataTableProveedores = new DataTable("proveedores");
            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();

                MySqlDataAdapter dataReader = new MySqlDataAdapter(comando);
                dataReader.Fill(dataTableProveedores);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al cargar proveedores del servidor {ex.Message}");
                dataTableProveedores = null;
            }
            finally
            {
                conexionDB.Close();
            }

            return dataTableProveedores;
        }

        public static void updateProveedor(
            int id,
            string nombre,
            int es_minorista,
            string porcentage_ganancia,
            string dni,
            string cuit,
            string ibb)
        {

            string querry = $"UPDATE proveedores SET id = '{id}', nombre  = '{nombre}', es_minorista  = '{es_minorista}', dni = '{dni}', porcentage_ganancia = '{porcentage_ganancia}', cuit = '{cuit}', ibb = '{ibb}' WHERE id = '{id}'";

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


//UPDATE from proveedores` SET`id` = '8',`nombre` = 'JEfa',`es_minorista` = '1',`dni` = '11111111',`porcentage_ganancia` = '1234',`cuit` = '1234',`ibb` = '5'WHERE `id` = '8';
