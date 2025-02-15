namespace Task_11_08
{   /*  
     *      Использование params и out: Напишите метод, который принимает переменное количество
     *      чисел и возвращает их сумму и максимальное значение через выходные параметры (out)
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum;
            int max;

            CalculateSumAndMax( out sum, out max, 1, 2, 3, 4, 5 );

            Console.WriteLine($"Сумма: {sum} \nМаксимальное значение: {max}");
        }

        public static void CalculateSumAndMax( out int sum, out int max, params int[] numbers)
        {
            sum = 0;
            max = 0;

            foreach (int number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }
        }
    }
}
