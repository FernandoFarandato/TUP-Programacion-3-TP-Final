using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    class UsuarioDB
    {

        public static bool validarUsuarioPassword(String password)
        {
            string querry = $"SELECT username, password FROM usuarios WHERE password='{password}'";

            MySqlDataReader dataReader = null;
            MySqlConnection conexionBD = ConexionDB.conexionBD();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querry, conexionBD);
                dataReader = comando.ExecuteReader();

                if (!dataReader.HasRows) return false;
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

    }
}
