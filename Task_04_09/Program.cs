namespace Task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 2, 4, 5, 6, 1, 7, 8, 6, 9, 10, 10 }; 
            int size = numbers.Length;

            
            int[] counts = new int[101]; 

            
            for (int i = 0; i < size; i++)
            {
                counts[numbers[i]]++;
            }

            
            Console.WriteLine("Уникальные элементы:");
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == 1)
                {
                    Console.Write(i + " ");
                }
    }
}
