using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicManagement
{
    public class User
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }

        public User(string username, string fullName, string role)
        {
            Username = username;
            FullName = fullName;
            Role = role;
        }
    }
}
