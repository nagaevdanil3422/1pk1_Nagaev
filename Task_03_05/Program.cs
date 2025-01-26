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
            double i = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечную температуру в градусах Цельсия: ");
            double er = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите шаг изменения температуры в градусах Цельсия: ");
            double w = Convert.ToDouble(Console.ReadLine());

            // Вывод заголовка таблицы
            Console.WriteLine("\nТемпература (°C) | Температура (°F)");
            Console.WriteLine("-------------------|-------------------");

            // Цикл для вычисления и вывода значений
            for (double celsius = i; celsius <= er; celsius += w)
            {
                double f = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius,-18:F2} | {f,-18:F2}");


            }
        }
    }
}