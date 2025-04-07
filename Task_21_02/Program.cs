namespace Task_21_02
{
    /*  Дан текст. Написать метод, который возвращает словарь, где ключ — слово, а значение —количество его вхождений в тексте. */
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Это пример текста, в котором мы будем считать количество вхождений слов. Слова могут повторяться, и мы хотим знать, сколько раз каждое слово встречается.";

            Dictionary<string, int> wordCount = CountWords(text);


            foreach (var pair in wordCount)
            {
                Console.WriteLine($"Слово: '{pair.Key}' - Количество: {pair.Value}");
            }
        }
        static Dictionary<string, int> CountWords(string text)
        {

            char[] znaki = new char[] { ' ', ',', '.', '!', '?', ';', ':' };
            string[] words = text.ToLower().Split(znaki, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }
    }
}
