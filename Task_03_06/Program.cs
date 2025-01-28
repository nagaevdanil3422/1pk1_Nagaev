namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4 ≤ x ≤ 4, с шагом h = 0,5.
            
            double i = -4.0;
            double e = 4.0;
            double s = 0.5;
            for (double x = i; x <= e; x += s)
            {
                double y = Math.Abs(x); 
                Console.WriteLine($"{x,6:F2} | {y,8:F2}");

              
                }
            }
        }
    }

