using System.IO.Compression;
using System.Net;
using System.Security.Cryptography;

namespace Task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int m = 5;

            int[,] masiv = new int[n, m];
            int[,] user = new int[m, n];
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    masiv[i, 0] = 0;
                    masiv[i, 1] = (i + 1) * 2;
                    masiv[i, 2] = (i + 1) * 3;
                    masiv[i, 3] = (i + 1) * 4;
                    masiv[i, 4] = (i + 1) * 5;
                    
                    Console.Write(masiv[i, j] + "\t");                   
                }
                Console.WriteLine();                               
            }
            Console.WriteLine();
            
            for (int i = 0; i < masiv.GetLength(0); ++i)
            {
                for (int j = 0; j< masiv.GetLength(1); ++j)
                {
                    user[j, i] = masiv[i, j];
                }
            }
            
            for (int i = 0; i < user.GetLength(0); i++)
            {
                for (int j = 0; j< user.GetLength(1); ++j)
                {
                    Console.Write(user[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
        }
    }
}
