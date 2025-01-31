namespace Task_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
                (это матрица, где все недиагональные элементы меньше нуля)
                Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
                вывести сообщение что данная матрица не является Z-матрицей 
             */

            int[,] tol =
            {
                {1,-2,-4,-5,-1 },
                {-4,1,-5,-1,-6 },
                {-5,-6,1,-5,-5 },
                {-5,-1,-5,1,-5 },
                {-1,-5,-5,-5,1 },
            };

            Console.WriteLine("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriza = new int[n, n];
            Random random = new Random();
            // Создание массива
            for (int i = 0; i < matriza.GetLength(0); i++)
            {
                for (int j = 0; j < matriza.GetLength(1); j++)
                {
                    matriza[i, j] = random.Next(-15, 16);
                }

            }

            bool isDiag = true;
            // Проверка является ли массив Z-матрицей
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
                    Console.WriteLine("данная матрица не является Z-матрицей");
                    break;
                }
            }
            // Вывод массива
            if (isDiag)
            {
                for (int i = 0; i < matriza.GetLength(0); i++)
                {
                    for (int j = 0; j < matriza.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(matriza[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matriza[i, j] + "\t");
                        }

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}