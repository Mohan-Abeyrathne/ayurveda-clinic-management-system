using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
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
