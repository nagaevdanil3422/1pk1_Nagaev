using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_38_04
{
    public class BazaData
    {
        private List<RegistrationStudent> students = new();
        
        public List<RegistrationStudent> Students => students;

        private const string saveFileName = "Students.json";

        

        public void SaveStudents()
        {
            try
            {
                var json = JsonSerializer.Serialize(students);
                File.WriteAllText(saveFileName, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
        public void LoadStudents()
        {
            try
            {
                var json = File.ReadAllText(saveFileName);
                students = JsonSerializer.Deserialize<List<RegistrationStudent>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
        }
    }
}

