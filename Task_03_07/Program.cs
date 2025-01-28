namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g * t ,
            // где 2 g = 9,8 м / с2 – ускорение свободного падения.
            const double g = 9.8;
            double tr = 0.0;
            double t1 = 5.0;
            double i = 0.5;

            for (double t = tr; t <= t1; t = i++)
            {
                double y = t * g;
                Console.WriteLine($"{t} | {y}");
                Console.WriteLine();


            }
        }
    }
}