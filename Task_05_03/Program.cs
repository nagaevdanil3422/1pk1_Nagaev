using System.Security.Cryptography;

namespace Task_05_03
{                /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
                   да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
                   элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.                 
                  */
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] masiv1 = new char[3, 3];
            char[,] masiv = new char[3, 3];
            Random random = new Random();


            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    masiv[i, j] = (char)random.Next('A', 'Z' + 1);
                    masiv1[i, j] = (char)random.Next('A', 'Z' + 1);
                }

            }
            for (int i = 0; i < masiv1.GetLength(0); i++)
            {
                for (int j = 0; j < masiv1.GetLength(1); j++)
                {
                    if (masiv[i, j].Equals(masiv1[i, j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(masiv[i, j] + "\t");
                        Console.Write(masiv1[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        
                        Console.Write(masiv[i, j] + "\t");                       
                        Console.Write(masiv1[i, j] + "\t");
                        
                    }                                     
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("матрицы не равны");

        }
    }
}
         
    


