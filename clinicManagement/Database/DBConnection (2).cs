using MySql.Data.MySqlClient;

namespace ClinicManagement
{
    public class DBConnection
    {
        private string connectionString =
        "server=localhost;database=clinicmanagement;uid=root;pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
