namespace Task_14_03
{       /*  Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал.
         *  Сделайтетак, чтобы метод работал только для неотрицательных чисел
         */
    internal class Program
    {
        internal static class Factorial
        {
            public static long FactorialNum(int number)
            {
                
                if (number < 0)
                {
                    Console.WriteLine("Факториал предназначен только для неотрицательных чисел");
                }
                long result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите неотрицательное целое число:");
            int input = int.Parse(Console.ReadLine());

            long factorial = Factorial.FactorialNum(input);
            Console.WriteLine($"Факториал {input} равен {factorial}.");
        }
    }
}
