using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Modelo
{
    public class ProductoDB
    {

        public static void crearProducto(string nombre_producto, string descripcion_producto, int marcas_id)
        {
            string querry = $"INSERT INTO productos (nombre_producto, descripcion_producto, marcas_id) VALUES ('{nombre_producto}', '{descripcion_producto}', '{marcas_id}')";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Producto guardado correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar Producto {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

        public static void eliminarProducto(int id)
        {
            string querry = $"DELETE from productos WHERE id_productos = '{id}';";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto Eliminado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar Producto {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

        //Falta Agregar Proveedor
        public static DataTable traerProductos_Precio_NombreMarca_NombrePorveedor()
        {
            string querry = $"SELECT p.id_productos, p.nombre_productos, p.descripcion_productos, i.nombre_marca, c.precio FROM precio AS c INNER JOIN marcas AS i INNER JOIN productos AS p ON c.productos_id=p.id_productos AND p.marcas_id=i.id_marcas";

            DataTable dataTableProductos = new DataTable("productos");
            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();

                MySqlDataAdapter dataReader = new MySqlDataAdapter(comando);
                dataReader.Fill(dataTableProductos);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al cargar marcas del servidor {ex.Message}");
                dataTableProductos = null;
            }
            finally
            {
                conexionDB.Close();
            }

            return dataTableProductos;
        }

        public static void updateProducto(int id, string nombre_producto, string descripcion_producto, int marcas_id)
        {
            string querry = $"UPDATE productos SET nombre_producto = '{nombre_producto}', descripcion_producto  = '{descripcion_producto}', marcas_id  = '{marcas_id}' WHERE id_productos = '{id}'";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto Actualizado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al actualizar el Producto {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }


    }
}
