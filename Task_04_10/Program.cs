namespace Task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];

            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 11); 
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);

           
            ReverseArray(numbers, 0, numbers.Length / 2 - 1);
            
            ReverseArray(numbers, numbers.Length / 2, numbers.Length - 1);

            Console.WriteLine("Массив после реверса:");
            PrintArray(numbers);
        }

        
        static void ReverseArray(int[] array, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
               
                int temp = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = temp;

              
                startIndex++;
                endIndex--;
            }
        }

        
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
