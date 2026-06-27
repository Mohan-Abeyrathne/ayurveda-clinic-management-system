using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyurvedaClinicSystem.Models
{
    internal class patients
    {
        public int PatientID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BloodType { get; set; }
        public string DoshaType { get; set; }
    }
}
