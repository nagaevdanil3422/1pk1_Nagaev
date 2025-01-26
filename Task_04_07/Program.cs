using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
                 отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
                 мальчиков и девочек. При выводе избавиться от отрицательных значений.

            */

            Random random = new Random();
            int[] rost = new int[30];

            for (int i = 0; i < 30; i++)
            {

                rost[i] = random.Next(-180, 201);
            }
            int boysCount = 0;
            int girlsCount = 0;
            int boysSum = 0;
            int girlsSum = 0;

            foreach (var height in rost)
            {
                if (height < 0) // Мальчики
                {
                    boysCount++;
                    boysSum += Math.Abs(height);
                }
                else // Девочки
                {
                    girlsCount++;
                    girlsSum += height;
                }

            }
            double averageBoysHeight = boysCount > 0 ? (double)boysSum / boysCount : 0;
            double averageGirlsHeight = girlsCount > 0 ? (double)girlsSum / girlsCount : 0;

            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост мальчиков: {averageBoysHeight:F2} см");
            Console.WriteLine($"Средний рост девочек: {averageGirlsHeight:F2} см");
        }

    }
}