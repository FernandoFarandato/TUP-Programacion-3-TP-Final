using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class UsuarioBD
    {
        public static bool validarUsuarioPassword(String password)
        {
            MySqlDataReader lector = null;
            string user = $"SELECT username, password FROM usuarios WHERE password='{password}'";

            MySqlConnection conexionBD = ConexionDB.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(user, conexionBD);
                lector = comando.ExecuteReader();

                if (!lector.HasRows)
                {
                    return false;
                }

                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error{e.Message}");
                return false;
            }
            finally
            {
                conexionBD.Close();                
            }

        }

        public static string cargarPassword()
        {
            MySqlDataReader lector = null;
            string user = $"SELECT password FROM usuarios WHERE id=1";

            MySqlConnection conexionBD = ConexionDB.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(user, conexionBD);
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    return lector.GetString(0);
                }

                return null;
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error al cargar usuario {e.Message}");
                return null;
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public static void modificarUsuario(string usuario, string password)
        {
            string usuarioNuevo = $"UPDATE usuarios SET Nombre='{usuario}', Password='{password}' WHERE id=1";

            MySqlConnection conexionBD = ConexionDB.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(usuarioNuevo, conexionBD);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al guardar {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public static String cargarUsuario()
        {
            MySqlDataReader lector = null;
            string user = $"SELECT username FROM usuarios WHERE id=1";

            MySqlConnection conexionBD = ConexionDB.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(user, conexionBD);
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    return lector.GetString(0);                  
                }

                return null;
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error al cargar usuario {e.Message}");
                return null;
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
