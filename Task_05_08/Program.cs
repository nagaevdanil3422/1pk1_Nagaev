using System.Security.Cryptography;

namespace Task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет 
                произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в 
                результирующий массив) 
                Вывести результирующий массив
            */


            Random rand = new Random();
            int[,] masiv = new int[10, 10];
            int[,] masiv2 = new int[10, 10];
            int[,] us = new int[10, 10];
            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {
                    masiv[i, j] = rand.Next(1, 10);
                    masiv2[i, j] = rand.Next(1, 10);
                    Console.Write(masiv[i, j] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < masiv.GetLength(0); i++)
            {
                for (int j = 0; j < masiv.GetLength(1); j++)
                {                    
                    Console.Write(masiv2[i, j] + " ");
                }
                Console.WriteLine();
            }


            
        }
        }
        

        
    }

