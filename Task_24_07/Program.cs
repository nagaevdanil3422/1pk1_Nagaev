namespace Task_24_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:path\toyour\file.txt"; // Укажите путь к вашему файлу
            string searchWord = "hello"; // Задайте слово для поиска

            try
            {
                List<string> matchingLines = FindLinesContainingWord(filePath, searchWord);

                if (matchingLines.Count > 0)
                {
                    Console.WriteLine("Найденные строки:");
                    foreach (string line in matchingLines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("Строки с заданным словом не найдены.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static List<string> FindLinesContainingWord(string filePath, string word)
        {
            List<string> matchingLines = new List<string>();

            
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matchingLines.Add(line);
                    }
                }
            }

            return matchingLines;
        }
    }
}
    
