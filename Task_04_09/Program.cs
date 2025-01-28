namespace Task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 2, 4, 5, 6, 1, 7, 8, 6, 9, 10, 10 };
            int s = num.Length;


            int[] cy = new int[101];


            for (int i = 0; i < s; i++)
            {
                cy[num[i]]++;
            }


            Console.WriteLine("Уникальные элементы:");
            for (int i = 0; i < cy.Length; i++)
            {
                if (cy[i] == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
