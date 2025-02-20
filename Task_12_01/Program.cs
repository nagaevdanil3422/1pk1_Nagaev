using ClassesDemo.Publications;

namespace ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal tom = new Journal();
            Console.WriteLine("Журнал о Скандинавском язычестве");

            string nameJ = tom.title;
            string dataJ = tom.data;
            string napravJ = tom.naprav;
            int strJ = tom.str;
            int mannyJ = tom.manny;

            tom.title = "Скандинавское язычество";
            tom.data = "12.07.2007г.";
            tom.naprav = "Культура";
            tom.str = 345;
            tom.manny = 1299;

            while (true)
            {
                Console.Write("Что хотите узнать о журнале?\n1. Данные о журнале\n2. Просмотр содержания журнала\n3. Покупка журнала\n4. Выйти из программы\n Введите цифру: ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    tom.GetInfo();
                }
                else if (input == "2")
                {
                    tom.Soder();
                }
                else if (input == "3")
                {
                    tom.Buy();
                }
                else if (input == "4")
                {
                    Console.WriteLine("Спасибо что были с нами!");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка...");
                }
                Console.WriteLine();
            }

        }
    }
}




