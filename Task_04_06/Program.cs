namespace Task_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Заполнить массив случайными положительными и отрицательными числами таким образом,
            чтобы все числа по модулю были разными.
            Это значит, что в массиве не может быть ни только двух равных чисел,
            но не может быть двух равных по модулю.
            В полученном массиве найти наибольшее по модулю число. 
            */

            Random random = new Random();
            int size = 20; 
            int[] numbers = new int[size];
            HashSet<int> usedModules = new HashSet<int>();

            int index = 0;

            while (index < size)
            {
                
                int number = random.Next(-100, 101); 

                
                if (usedModules.Add(Math.Abs(number)))
                {
                    numbers[index] = number;
                    index++;
                }
            }

            
            Console.WriteLine("Сгенерированный массив:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            
            int i = numbers[0];

            foreach (var num in numbers)
            {
                if (Math.Abs(num) > Math.Abs(i))
                {
                    i = num;
                }
            }

            Console.WriteLine($"Наибольшее по модулю число: {i}");

        }
    }
}
