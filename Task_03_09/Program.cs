using System.Xml.Schema;

namespace Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
                отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
                менее y рублей.
            */
            Console.WriteLine("Ввведите начальную сумму вклада: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент увеличения: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите полную сумму: ");
            double y = Convert.ToDouble(Console.ReadLine());
            int years = 0;

            while (x < y)
            {
                x += x * (a / 100);
                x = Math.Floor(x * 100) / 100;
                years++;
            }
            Console.WriteLine($"Вклад достигнет не менее {y} рублей через {years} лет.");
        }
    }
}
