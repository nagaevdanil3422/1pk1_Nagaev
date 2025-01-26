namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g * t ,
            // где 2 g = 9,8 м / с2 – ускорение свободного падения.
            const double g = 9.8;
            double time = 0.0;
            double time1 = 5.0;
            double i = 0.5;

            for (double t = time; t <= time1; t = i++)
            {
                double y = t * g;
                Console.WriteLine($"{t} | {y}");
                Console.WriteLine();


            }
        }
    }
}