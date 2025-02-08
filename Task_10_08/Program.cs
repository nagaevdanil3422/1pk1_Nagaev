using System.ComponentModel.DataAnnotations;

namespace Task_10_08
{
    internal class Program
    {   /*  Создайте метод, который на вход принимает одномерный массив
         *  и число для поиска, верните индекс искомого элемента в массиве.
         *  Если элемента нет – верните индекс = -1
         */
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int numberToFind = 7;

            int index = Index(array, numberToFind);

            if (index != -1)
            {
                Console.WriteLine($"Элемент {numberToFind} найден по индексу: {index}");
            }
            else
            {
                Console.WriteLine($"Элемент {numberToFind} не найден в массиве");
            }
        }
        /// <summary>
        /// Находим елемент по индексу
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="number">число</param>
        /// <returns>Индекс искомого элемента в массиве</returns>
        public static int Index(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i; 
                }
            }
            return -1; 
        }
    }
}

