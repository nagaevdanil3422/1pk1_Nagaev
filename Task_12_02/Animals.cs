using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02
{
    class Animals
    {
        public string nameCat;
        public int ageCat;
        public string IsHappyCat;
        public string nameDog;
        public int ageDog;
        public string IsHappyDog;

        public void InfoCat()
        {
            Console.WriteLine($"Name cat: {nameCat}");
            Console.WriteLine($"Age cat: {ageCat}");
            Console.WriteLine($"Is the cat happy: {IsHappyCat}");
        }
        public void InfoDog()
        {
            Console.WriteLine($"Name dog: {nameDog}");
            Console.WriteLine($"Age dog: {ageDog}");
            Console.WriteLine($"Is the dog happy: {IsHappyDog}");
        }
    }
}
