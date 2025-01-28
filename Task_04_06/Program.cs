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

            Random rnd = new Random();
            int size = 20; 
            int[] num = new int[size];
            HashSet<int> to = new HashSet<int>();

            int index = 0;

            while (index < size)
            {
                
                int nume = rnd.Next(-100, 101); 

                
                if (to.Add(Math.Abs(nume)))
                {
                    num[index] = nume;
                    index++;
                }
            }

            
            Console.WriteLine("Сгенерированный массив:");
            foreach (int nume in num)
            {
                Console.WriteLine(num);
            }

            
            int i = num[0];

            foreach (int nume in num)
            {
                if (Math.Abs(nume) > Math.Abs(i))
                {
                    i = nume;
                }
            }

            Console.WriteLine($"Наибольшее по модулю число: {i}");

        }
    }
}
