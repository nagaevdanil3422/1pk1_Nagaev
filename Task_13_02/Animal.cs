using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    class Animal
    {
        public class Animals
        {
            
            public string Name { get; set; }
            public string Species { get; set; }
            public int Age { get; set; }
            public double Weight { get; set; }
            public bool IsHealthy { get; set; } 

            
            public Animals()
            {
                Name = "Неизвестно";
                Species = "Неизвестно";
                Age = 0;
                Weight = 0.0;
                IsHealthy = true;
            }

            
            public Animals(string name, string species, int age, double weight, bool isHealthy)
            {
                Name = name;
                Species = species;
                Age = age;
                Weight = weight;
                IsHealthy = isHealthy;
            }

            
            public void DisplayInfo()
            {
                Console.WriteLine($"Кличка: {Name}");
                Console.WriteLine($"Вид: {Species}");
                Console.WriteLine($"Возраст: {Age} лет");
                Console.WriteLine($"Вес: {Weight} кг");
                Console.WriteLine($"Состояние здоровья: {(IsHealthy ? "Здоров" : "Нездоров")}");
            }

            
            public void ChangeWeight(double newWeight)
            {
                Weight = newWeight;
                Console.WriteLine($"Вес питомца изменен на: {Weight} кг");
            }

            
            public void ChangeHealthStatus(bool healthStatus)
            {
                IsHealthy = healthStatus;
                Console.WriteLine($"Состояние здоровья изменено на: {(IsHealthy ? "Здоров" : "Нездоров")}");
            }
        }              
    }
}