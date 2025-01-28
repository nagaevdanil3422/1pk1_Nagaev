namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
                которых равны.
            */
            Random rnd = new Random();
            int[] ra = new int[50];
            for (int i = 0; i < 50; i++)
            {

                ra[i] = rnd.Next(1, 11);
            }
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int number in ra)
            {
                counts[number] = counts.GetValueOrDefault(number, 0) + 1;
            }
            int pk = 0;
            foreach (int count in counts.Values)
            {
                if (count > 1)
                {
                    pk += count * (count - 1) / 2; 
                }
            }
            Console.WriteLine($"Количество пар элементов, которыe равны: {pk}");
            



        }
    }
}
