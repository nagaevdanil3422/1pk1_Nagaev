namespace Task_24_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:path\toyour\file.txt"; //укажите свой путь к файлк

            try
            {
                int lineCount = CountLinesInFile(filePath);
                Console.WriteLine($"Количество строк в файле: {lineCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static int CountLinesInFile(string filePath)
        {
            int lineCount = 0;

            
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null) 
                {
                    lineCount++;
                }
            }

            return lineCount;
        }

    }
    }

