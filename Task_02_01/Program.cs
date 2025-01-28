namespace Task_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввод данных
            Console.WriteLine("введите первое число (a)");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе число (b)");
            double b = Convert.ToDouble(Console.ReadLine());

            //вычисление и вывод результата
            double sum = a + b;
            Console.WriteLine("сумма чисел: " + sum);

            double pli = a * b;
            Console.WriteLine("произведение чисел: " + pli);
            double ro = a - b;
            Console.WriteLine("разность чисел: " + ro);
            double tt;
            if (b != 0)
            {
                tt = a / b;
                Console.WriteLine("деление a на b: " + tt);
            }
            else
            {
                Console.WriteLine("деление на ноль");
            }
        }
    }
}