using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PZ_03
{
    public static class EmergencyDepartment
    {
        private static List<Patient> patients = new List<Patient>();
        private const string filePath = "patients.json";

        // Метод для загрузки данных из файла
        public static void LoadPatients()
        {
            if (!File.Exists(filePath))
            {
                using (var stream = new FileStream(filePath, FileMode.Open)) ;
                var formatter = new BinaryFormatter();
                patients = (List<Patient>)formatter.Deserialize(stream); 
            }
        }

    }
}
