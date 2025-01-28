namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
              Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
              время работы программы
             */
            Console.Write("Введите начальную температуру в градусах Цельсия: ");
            double user = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечную температуру в градусах Цельсия: ");
            double user1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите шаг изменения температуры в градусах Цельсия: ");
            double user2 = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("\n      (°C)         |       (°F)");
            Console.WriteLine("-------------------|-------------------");

            
            for (double celsius = user; celsius <= user1; celsius += user2)
            {
                double f = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius,-18:F2} | {f,-18:F2}");


            }
        }
    }
}