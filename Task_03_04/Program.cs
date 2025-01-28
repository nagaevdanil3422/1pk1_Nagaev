namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter texts: ");
            while (true)
            {
                string? input = Console.ReadLine();
                if (input == "exit")
                {
                    
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter texts: ");
                    

                    continue;
                }
            }
        }
    }
}
