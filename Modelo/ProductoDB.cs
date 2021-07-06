using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Modelo
{
    public class ProductoDB
    {

        public static void crearProducto(string nombre_producto, string descripcion_producto, int marcas_id, int id_proveedor)
        {
            string querry = $"INSERT INTO productos (nombre_productos, descripcion_productos, marcas_id) VALUES ('{nombre_producto}', '{descripcion_producto}', '{marcas_id}')";

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

        public static void crearRelacionProductoProveedor(int id_proveedor, int id_productos)
        {
            string querry = $"INSERT INTO proveedores_has_productos (proveedores_id,productos_id) VALUES ('{id_proveedor}', '{id_productos}'); ";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Relacion guardada correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar Relacion {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

        public static void eliminarRelacionProductoProveedor(int id_productos, int id_proveedor)
        {
            string querry = $"DELETE from proveedores_has_productos WHERE proveedores_id = '{id_proveedor}' AND productos_id = '{id_productos}'";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Relacion Eliminada");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar Relacion {ex.Message}");
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

        public static int traerID(string nombre_producto, string descripcion_producto, int marcas_id)
        {

            int id = -1;
            string querry = $"SELECT id_productos FROM productos WHERE nombre_productos LIKE '{nombre_producto}' AND descripcion_productos LIKE '{descripcion_producto}' AND marcas_id = '{marcas_id}' LIMIT 1";

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

        public static DataTable traerProductos_Precio_NombreMarca_NombrePorveedor()
        {
            string querry = $"SELECT p.id_productos, p.nombre_productos, p.descripcion_productos, i.nombre_marca, c.precio, proveedores.nombre FROM precio AS c INNER JOIN marcas AS i INNER JOIN productos AS p INNER JOIN proveedores_has_productos AS rel INNER JOIN proveedores AS proveedores ON c.productos_id=p.id_productos AND p.marcas_id=i.id_marcas AND rel.productos_id=p.id_productos AND rel.proveedores_id=proveedores.id";

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

        public static void updateProducto(int id, string nombre_producto, string descripcion_producto, int marcas_id, int id_proveedor)
        {
            string querry = $"UPDATE productos SET nombre_productos = '{nombre_producto}', descripcion_productos  = '{descripcion_producto}', marcas_id  = '{marcas_id}' WHERE id_productos = '{id}'";

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
