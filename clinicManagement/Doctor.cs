using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicManagement
{
    public class Doctor : User
    {
        public Doctor(string username, string fullName) : base(username, fullName, "doctor")
        {
        }
    }
}
