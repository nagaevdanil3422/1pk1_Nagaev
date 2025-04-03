namespace Task_19_01
{
    /*  Напишите программу, в которой пользователь вводит произвольный текст в консоли, после чего
        программа запрашивает подстроку для поиска. Если подстрока найдена - то программа запрашивает
        текст для того чтобы заменить на него эту подстроку (столько раз, сколько раз подстрока встречена в тексте)
            Пример:
            Введите строку: "Привет, мир!"
            Введите подстроку для поиска: "мир"
            Введите подстроку для замены: "друг"
            Результат: "Привет, друг!"*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string user = Console.ReadLine();
            Console.Write("Введите подстроку для поиска: ");
            string explore = Console.ReadLine();


            if (user.Contains(explore))
            {
                Console.Write("Введите подстроку для замены: ");
                string barter = Console.ReadLine();
                string result = user.Replace(explore, barter);
                Console.WriteLine("Результат: " + result);
            }
            else
                Console.WriteLine("Такой подстроки нет");


        }
    }
}
