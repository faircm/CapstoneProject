using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace C969Assessment
{
    // This class consolidates database functionality, preventing code bloat
    internal class DatabaseConnection
    {
        public static string connectionStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        public static MySqlConnection connection = new MySqlConnection(connectionStr);


        public static void openConnection()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
