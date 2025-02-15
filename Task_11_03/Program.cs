using System.Linq;

namespace Task_11_03
{   /*  Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
        выходной параметр количество гласных и согласных букв в этой строке
    */
    internal class Program
    {
        static void Main()
        {
            string input = "Привет мой друг. Давай погуляем?";
            int glass, sogl;

            StringOut(input, out glass, out sogl);
            Console.WriteLine($"Количество гласных в строке: {glass}");
            Console.WriteLine($"Количество согласных в строке: {sogl}");
        }
        /// <summary>
        /// Метод который считает количество гласных и согласных
        /// </summary>
        /// <param name="input"></param>
        /// <param name="glass"></param>
        /// <param name="sogl"></param>
        public static void StringOut(string input, out int glass, out int sogl)
        {
            glass = 0;
            sogl = 0;

            
            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

            foreach (char c in input)
            {
                if (char.IsLetter(c)) 
                {
                    if (vowels.Contains(c)) 
                    {
                        glass++;
                    }
                    else 
                    {
                        sogl++;
                    }
                }
            }
        }
    }
}
