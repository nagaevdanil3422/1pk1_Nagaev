using System.Diagnostics.CodeAnalysis;

namespace Task_11_05
{  /*  
    *  Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и
    *  возвращает их сумму и произведение через выходные параметры (out)
    */
    internal class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 6;
            Numbers(ref a, ref b, out int sum, out int proiz);
            Console.WriteLine($"Сумма чисел: {sum}");
            Console.WriteLine($"Произведение чисел: {proiz}");

        }
        public static void Numbers(ref int x, ref int y, out int sum, out int proiz)
        {
            sum = x + y;
            proiz = x * y;
            
        }
        
    }
}
