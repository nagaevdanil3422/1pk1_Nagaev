namespace Task_11_02
{   /*  Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
        меняет их местами. Проверьте, изменились ли значения переменных вне метода
    */
    internal class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"До вызова метода: a = {a}, b = {b}");
            SwapByValue(a, b);
            Console.WriteLine($"После вызова метода: a = {a}, b = {b}");
        }
        /// <summary>
        /// Метод который меняет значения
        /// </summary>
        /// <param name="x">значение а</param>
        /// <param name="y">значение b</param>
        static void SwapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
