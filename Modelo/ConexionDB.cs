using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;
 

namespace Modelo
{
    public class ConexionDB
    {
        public static MySqlConnection conexionBD()
        {
            string servidor = ConfigurationManager.AppSettings["servidor"];
            string bd = ConfigurationManager.AppSettings["bd"];
            string usuario = ConfigurationManager.AppSettings["usuario"];
            string password = ConfigurationManager.AppSettings["password"];

            string cadenaConexion = $"Database={bd}; Data Source={servidor}; Port=3307; User Id={usuario}; Password={password};";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error {e.Message}");
                return null;
            }
        }
    }
}
