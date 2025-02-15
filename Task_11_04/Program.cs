using System.Diagnostics.CodeAnalysis;

namespace Task_11_04
{   /*  
     *  Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает их среднее значение.
     *  Используйте ключевое слово params
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double average1 = CalculateAverage(1, 2, 7, 4, 6);
            Console.WriteLine($"Среднее значение: {average1}");

            double average2 = CalculateAverage();
            Console.WriteLine($"Среднее значение: {average2}"); 
        }

        public static double CalculateAverage(params double[] numbers)
        {
            if (numbers.Length == 0) 
            {
                return 0; 
            }

            double sum = 0;

            foreach (double number in numbers)
            {
                sum += number; 
            }

            return sum / numbers.Length; 
        }
    }
}
