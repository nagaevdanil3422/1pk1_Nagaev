using System.Threading.Channels;

namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 14;
            double c = Math.PI / 4;
            double z = Math.Abs(a - b);
            double x = Math.Pow(Math.Sin(c), 2) + Math.Tan(c);
            double v = z * x;
            
            double K = Math.Pow(b + Math.Pow(a - 1, 1.0 / 3.0), 1.0 / 4.0);
            double o = K / v;
            Console.WriteLine(o);
  
        }
    }
}
