using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicManagement
{
    public class Staff : User
    {
        public Staff(string username, string fullName) : base(username, fullName, "staff")
        {
        }
    }
}
