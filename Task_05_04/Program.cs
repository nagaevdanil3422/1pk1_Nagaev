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

            int[,] tol =
            {
                {1,-2,-4,-5,-1 },
                {-4,1,-5,-1,-6 },
                {-5,-6,1,-5,-5 },
                {-5,-1,-5,1,-5 },
                {-1,-5,-5,-5,1 },
            };

            int n = int.Parse(Console.ReadLine());
            int[,] user = new int[n, n];

            for (int i = 0; i < user.GetLength(0); i++)
            {
                for (int j = 0; j < user.GetLength(1); j++)
                {
                    user[i, j] = random.Next(-9, 10);
                }

            }
            bool isDiag = true;
            // Проверка является ли массив диагональной
            for (int i = 0; i < tol[i, 3]; i++)
            {
                for (int j = 0; j < tol[i, j]; j++)
                {
                    if (i != j && tol[i, j] > 0)
                        isDiag = false;
                    break;
                }
                if (!isDiag)
                {
                    Console.WriteLine("данная матрица не является диагональной");
                    break;
                }
            }
            if (isDiag)
            {
                for (int i = 0; i < user.GetLength(0); i++)
                {
                    for (int j = 0; j < user.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(user[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(user[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}

