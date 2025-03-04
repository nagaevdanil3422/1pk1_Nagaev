using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03
{
    public class Car
    {
        
        public string LicensePlate { get; set; } 
        public string Brand { get; set; }         
        public string Color { get; set; }     
        public double CurrentSpeed { get; private set; } 

        private const double MaxSpeed = 200.0; 

        
        public Car()
        {
            LicensePlate = "Неизвестно";
            Brand = "Неизвестно";
            Color = "Неизвестно";
            CurrentSpeed = 0.0;
        }

        
        public Car(string licensePlate, string brand, string color)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = 0.0;
        }

        
        public void Accelerate(double increment)
        {
            CurrentSpeed += increment;
            if (CurrentSpeed > MaxSpeed)
            {
                Console.WriteLine($"Скорость превышена! Текущая скорость: {CurrentSpeed} км/ч. Автомобиль остановлен.");
                CurrentSpeed = 0; 
            }
            else
            {
                Console.WriteLine($"Автомобиль разогнался до {CurrentSpeed} км/ч.");
            }
        }

        
        public void Brake()
        {
            if (CurrentSpeed > 0)
            {
                Console.WriteLine($"Автомобиль тормозит. Текущая скорость: {CurrentSpeed} км/ч.");
                CurrentSpeed = 0; 
                Console.WriteLine("Автомобиль остановлен.");
            }
            else
            {
                Console.WriteLine("Автомобиль уже остановлен.");
            }
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"Номер авто: {LicensePlate}");
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Текущая скорость: {CurrentSpeed} км/ч");
        }
    }


}
