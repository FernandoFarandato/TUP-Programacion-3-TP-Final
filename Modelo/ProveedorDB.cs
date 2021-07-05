using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Modelo
{
    public class ProveedorDB
    {
        public static DataTable getAll()
        {
            string querry = $"SELECT p.id, p.nombre, p.dni, p.porcentage_ganancia, p.cuit, p.ibb FROM proveedores AS p";

            DataTable listaProveedores = new DataTable("Proveedores");

            MySqlConnection conexionBD = Conexion.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionBD);
                comando.ExecuteNonQuery();

                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                datos.Fill(listaProveedores);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al cargar proveedores. {ex.Message}");
                listaProveedores = null;
            }
            finally
            {
                conexionBD.Close();
            }

            return listaProveedores;
        }

        public static void crearProveedor(
            string nombre, 
            int es_minorista,
            string dni,
            string porcentage_ganancia,
            string cuit,
            string ibb)
        {

            string querry;

            if (es_minorista == 0) querry = $"INSERT INTO proveedores (nombre, es_minorista, dni, porcentage_ganancia, cuit, ibb) VALUES ('{nombre}', '{es_minorista}', '{dni}', '{porcentage_ganancia}', '{cuit}', '{ibb}')";
            else querry = $"INSERT INTO proveedores (nombre, es_minorista, dni, porcentage_ganancia, cuit, ibb) VALUES ('{nombre}', '{es_minorista}', '{dni}', '5', '{cuit}', '{ibb}')";


            MySqlConnection conexionBD = Conexion.conexionBD();
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
    
        public static int obtenerId(string nombre, int es_minorista, string dni, string cuit)
        {
            int id = 0;
            string querry;

            if (es_minorista == 1) querry = $"SELECT id FROM proveedores WHERE nombre LIKE '{nombre}' AND es_minorista = '1' AND dni LIKE '{dni}' LIMIT 1"; 
            else querry = $"SELECT id FROM proveedores WHERE nombre LIKE '{nombre}' AND es_minorista = '0' AND cuit LIKE '{cuit}' LIMIT 1";

            MySqlDataReader lector = null;
            MySqlConnection conexionBD = Conexion.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionBD);
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    id = int.Parse(lector.GetString(0));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error al buscar idDireccion {e.Message}");

            }
            finally
            {
                conexionBD.Close();
            }

            return id;
        }
    
        public static DataTable obtenerProveedores()
        {
            string querry = $"SELECT p.id, p.nombre, p.dni, p.porcentage_ganancia, p.cuit, p.ibb FROM proveedores AS p ";
            
            DataTable tabla_proveedores = new DataTable("proveedores");
            
            MySqlConnection conexionBD = Conexion.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionBD);
                comando.ExecuteNonQuery();
                MySqlDataAdapter data = new MySqlDataAdapter(comando);

                data.Fill(tabla_proveedores);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"No se pudieron cargar los proveedores. {ex.Message}");
                tabla_proveedores = null;
            }
            finally
            {
                conexionBD.Close();
            }

            return tabla_proveedores;
        }

        public static DataTable obtenerProveedoresYDireccionYTelefono()
        {
            string querry = $"SELECT p.id, p.nombre, p.dni, p.porcentage_ganancia, p.cuit, p.ibb, d.calle, d.numero, d.cuidad, d.provincia FROM proveedores AS p INNER JOIN direcciones AS d WHERE d.proveedores_id=p.id";

            DataTable tabla_proveedores = new DataTable("proveedores");

            MySqlConnection conexionBD = Conexion.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionBD);
                comando.ExecuteNonQuery();
                MySqlDataAdapter data = new MySqlDataAdapter(comando);

                data.Fill(tabla_proveedores);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"No se pudieron cargar los proveedores. {ex.Message}");
                tabla_proveedores = null;
            }
            finally
            {
                conexionBD.Close();
            }

            return tabla_proveedores;
        }

        public static void eliminarProveedor(int id)
        {
            string querry = $"DELETE from proveedores WHERE id = '{id}'";
            //Select COUNT(*) from proveedores;
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

        public static int contarProveedores()
        {
            string querry = $"Select COUNT(*) from proveedores";
            int cant = 0;
            MySqlConnection conexionBD = Conexion.conexionBD();
            MySqlDataReader lector = null;
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionBD);
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    cant = int.Parse(lector.GetString(0));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
            }
            return cant;
        }
    }

}
