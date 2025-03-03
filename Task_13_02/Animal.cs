using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    class Animal
    {
        public string name;
        public string vidanimals;
        public int age;
        public int weight;
        public string health;


        public void InfoAnimals()
        {
            Console.Write($"Кличка животного: {name}\nВид животного: {vidanimals}\nВозраст: {age}\nВес: {weight}\nСостояние о здоровья: {health}");
        }

        
        
        public int SetWeight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}