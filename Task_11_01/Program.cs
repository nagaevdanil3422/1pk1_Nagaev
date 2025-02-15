namespace Task_11_01
{   /*  
        Передача по значению: Напишите метод, который принимает два целых числа и меняет их местами.
      Проверьте, изменились ли значения переменных вне метода
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

        static void SwapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
