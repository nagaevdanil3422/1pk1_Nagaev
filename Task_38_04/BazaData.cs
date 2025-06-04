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
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private StatusPol selectedIndex;
        private int v;

        public List<RegistrationStudent> Students => students;

        private const string saveFileName = "Students.json";

        public BazaData(string text1, string text2, string text3, string text4, StatusPol selectedIndex, int v)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.selectedIndex = selectedIndex;
            this.v = v;
        }

        public BazaData()
        {
        }

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

