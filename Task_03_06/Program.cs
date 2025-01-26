namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4 ≤ x ≤ 4, с шагом h = 0,5.
            
            double startX = -4.0;
            double endX = 4.0;
            double step = 0.5;
            for (double x = startX; x <= endX; x += step)
            {
                double y = Math.Abs(x); 
                Console.WriteLine($"{x,6:F2} | {y,8:F2}");
            }
        }
    }
}
