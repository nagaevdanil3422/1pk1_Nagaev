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

            Random rnd = new Random();
            int[] ri = new int[30];

            for (int i = 0; i < 30; i++)
            {

                ri[i] = rnd.Next(-180, 201);
            }
            int b = 0;
            int g = 0;
            int by = 0;
            int gi = 0;

            foreach (var height in ri)
            {
                if (height < 0) 
                {
                    b++;
                    by += Math.Abs(height);
                }
                else 
                {
                    g++;
                    gi += height;
                }

            }
            double ert = b > 0 ? (double)by / b : 0;
            double erty = g > 0 ? (double)gi / g : 0;

            Console.WriteLine($"Количество мальчиков: {b}");
            Console.WriteLine($"Количество девочек: {g}");
            Console.WriteLine($"Средний рост мальчиков: {ert:F2} см");
            Console.WriteLine($"Средний рост девочек: {erty:F2} см");
        }

    }
}