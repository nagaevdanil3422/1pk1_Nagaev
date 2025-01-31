namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
                диагональной (все элементы вне главной диагонали равны нулю)
                Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
                сообщение что матрица не является диагональной.
            */
            Random random = new Random();

            int n = int.Parse(Console.ReadLine());
            int[,] user = new int[n, n];

            for (int i = 0; i < user.GetLength(0); i++)
            {
                for (int j = 0; j < user.GetLength(1); j++)
                {
                    user[i, j] = random.Next(-9, 10);
                }

            }
            for (int i = 0; i < user.GetLength(0); i++)
            {
               for(int j = 0;j < user.GetLength(1); j++)
               {
                    if (i == j)
                    {
                        Console.Write(user[i, j] + "  ");
                    }
                    else if (i != j)
                    {
                        
                    }
               }

                Console.WriteLine();
            }





        }       
    }
}
