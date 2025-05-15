using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_38_04
{
    internal class BazaData
    {
        List<RegistrationStudent> students = new();
        List<RegistrationStudent> Students => students;
        private string saveFileName = "Students.json";
        public void SaveStudents()
        {
            
                
            
        }
    }
}
