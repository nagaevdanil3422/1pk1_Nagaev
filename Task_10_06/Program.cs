using System.Security.Cryptography;

namespace Task_10_06
{
    internal class Program
    {   //Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n, выводит на консоль сгенерированный массив размерности n*n.

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                ArrayGeneration();
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Выводит массив размером n*n 
        /// </summary>
        public static void ArrayGeneration()
        {
            Random random = new Random();
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }



        }
        
                         
                    
        
        
    }
}
