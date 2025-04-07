namespace Task_24_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:path\toyour\file.txt"; // Укажите путь к вашему файлу

            try
            {
                Console.Write("Введите слово для поиска: ");
                string searchWord = Console.ReadLine();

                Console.Write("Введите новое слово для замены: ");
                string replacementWord = Console.ReadLine();

                ReplaceTextInFile(filePath, searchWord, replacementWord);
                Console.WriteLine("Замена завершена.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void ReplaceTextInFile(string filePath, string searchWord, string replacementWord)
        {
            
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            
            string[] lines = File.ReadAllLines(filePath);

            
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(searchWord, replacementWord, StringComparison.OrdinalIgnoreCase);
            }

            
            File.WriteAllLines(filePath, lines);
        }
    }
}
   
