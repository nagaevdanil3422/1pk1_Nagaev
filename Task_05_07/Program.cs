using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Sources;

namespace Task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int n = int.Parse(Console.ReadLine());
            int[,] user = new int[n, n];
            
            for (int i = 0; i < user.GetLength(0); i++)
            {
                for (int j = 0; j < user.GetLength(1); j++)
                {
                    user[i, j] = random.Next(10, 100);
                }
            }
            // Находим минимальный элемент в матрице
            for (int i = 0; i < user.GetLength(0); i++)
            {
                for (int j = 0; j < user.GetLength(1); j++)
                {
                    user[i, j] = Math.Min(i, j);
                    Console.Write(user[i, j] + "  ");
                    
                }
                Console.WriteLine();
                Console.WriteLine("Минимальный элемент: " + user[i, j]);
            }
            

        }
    }
}