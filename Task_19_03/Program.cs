namespace Task_19_03
{
    /*  Напишите консольное приложение, в котором осуществляется построчный пользовательский
        ввод (ввод каждой строки подтверждается нажатием на enter). количество введенных строк
        произвольно, ввод завершается при вводе пустой строки.
        После окончания ввода произведите объединение всех ранеее введенных строк в одну с
        использованием разделителя «-»
        Например:
        Введите строку 1: "Hello"
        Введите строку 2: "world"
        Введите строку 3: "C#"
        Результат: "Hello-world-C#"*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Введите текст(для завершения введите пустую строку): ");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }    
                list.Add(input);
            } 
            string result = string.Join("-", list);
            Console.WriteLine($"\nРезультат: { result} ");
        }
    }
}
