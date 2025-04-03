namespace Task_19_02
{
    /*  Напишите программу, которая запрашивает у пользователя произвольный текст, содержащий
        предложения (есть знаки препинания). программу после анализа выводит текст, разделенный на
        части:
        a)
        По пробелам (отдельные слова построчно)
        b)
        По предложениям (отдельные предложения построчно)
        (используйте метод Split())
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст с знаками препинания: ");
            string text = Console.ReadLine();

            Console.WriteLine("\nСлова по отдельности:");
            string[] words = text.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\nПредложения по отдельности:");
            char[] znaki = new char[] { '.', '!', '?' };
            string[] sentences = text.Split(znaki, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentence in sentences)
            {

                Console.WriteLine(sentence.Trim());

            }
        }
    }
}
