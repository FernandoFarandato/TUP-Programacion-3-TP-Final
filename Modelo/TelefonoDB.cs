using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class TelefonoDB
    {

        public static void crearTelefono(string numero_contacto, int proveedores_id)
        {
            string querry = $"INSERT INTO telefonos (numero_contacto, proveedores_id) VALUES ('{numero_contacto}', '{proveedores_id}')";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show($"Telefono guardado correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar Telefono {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

        public static void eliminarTelefono(int proveedores_id)
        {
            string querry = $"DELETE from telefonos WHERE proveedores_id = '{proveedores_id}';";

            MySqlConnection conexionDB = ConexionDB.conexionBD();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Telefono Eliminado correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar el Telefono {ex.Message}");
            }
            finally
            {
                conexionDB.Close();
            }
        }

        public static void updateTelefono(string numero_contacto, int proveedores_id)
        {

            string querry = $"UPDATE telefonos SET numero_contacto = '{numero_contacto}' WHERE proveedores_id = '{proveedores_id}'";

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
