using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyurvedaClinicSystem.Database
{
    internal class DBConnection
    {
        private string connectionString = "server=localhost;database=clinicmanagement;uid=root;pwd=1234;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
