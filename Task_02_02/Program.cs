using System.Threading.Channels;

namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 14;
            double sum = Math.PI / 4;
            double z = Math.Abs(a - b);
            double x = Math.Pow(Math.Sin(sum), 2) + Math.Tan(sum);
            double vo = z * x;
            
            double us = Math.Pow(b + Math.Pow(a - 1, 1.0 / 3.0), 1.0 / 4.0);
            double o = us / vo;
            Console.WriteLine(o);
  
        }
    }
}
