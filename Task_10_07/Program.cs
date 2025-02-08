namespace Task_10_07
{
    internal class Program
    {
        /* Создайте метод с помощью которого можно сгенерировать 
         * и вернуть символьный двумерный массив(состоящийиз символов русского алфавита) 
         * и выведите на консоль данный массив с помощью другого метода(который принимает данный массив в качестве параметра)
         */
        static void Main(string[] args)
        {

            Print();
        }
        /// <summary>
        /// Генерация символьного двумерного массива
        /// </summary>
        /// <returns>Массив</returns>
        public static char[,] ArrayGeneration()
        {
            Random random = new Random();
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            char[,] array = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    array[i, j] = (char)random.Next('а', 'я' + 1);
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
            
            return array;
        }
        /// <summary>
        /// Вывод двумерного массива
        /// </summary>
        public static void Print()
        {
            ArrayGeneration();
        }


    }
}

