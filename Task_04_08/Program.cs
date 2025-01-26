namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
                которых равны.
            */
            Random random = new Random();
            int[] rast = new int[50];

            for (int i = 0; i < 50; i++)
            {

                rast[i] = random.Next(1, 11);
            }

            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (var number in rast)
            {
                counts[number] = counts.GetValueOrDefault(number, 0) + 1;
            }

            int pairsCount = 0;
            foreach (var count in counts.Values)
            {
                if (count > 1)
                {
                    pairsCount += count * (count - 1) / 2; 
                }
            }

            
            Console.WriteLine($"Количество пар элементов, значения которых равны: {pairsCount}");



        }
    }
}
