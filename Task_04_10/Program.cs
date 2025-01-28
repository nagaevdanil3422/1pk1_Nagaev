namespace Task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] num = new int[10];

            
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(-10, 11); 
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(num);

           
            ReverseArray(num, 0, num.Length / 2 - 1);
            
            ReverseArray(num, num.Length / 2, num.Length - 1);

            Console.WriteLine("Массив после реверса:");
            PrintArray(num);
        }

        
        static void ReverseArray(int[] array, int s, int e)
        {
            while (s < e)
            {
               
                int temp = array[s];
                array[s] = array[e];
                array[e] = temp;

              
                s++;
                e--;
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
