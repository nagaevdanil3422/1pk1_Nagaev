namespace Task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m].
                Заполнение случайными числами в диапазоне от -99 до 99 включительно.
                Осуществите без создания нового массива преобразование текущего по следующему правилу:
                    • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
                    • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом
            */

            Console.WriteLine("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matriza = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < matriza.GetLength(0); i++)
            {
                for (int j = 0; j < matriza.GetLength(1); j++)
                {
                    matriza[i, j] = random.Next(-99, 99);
                }

            }
            for (int i = 0; i < matriza.GetLength(0); i++)
            {
                for (int j = 0; j < matriza.GetLength(1); j++)
                {
                    if (matriza[i, j] < 0)
                    {
                        matriza[i, j] = Math.Abs(matriza[i, j]);
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (matriza[i, j] == 0)
                    {
                        matriza[i, j] = random.Next(-99, 0);
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(matriza[i, j] + "\t");
                    Console.ResetColor();

                      
                }
                Console.WriteLine();
            }
            
                



            }
        }
    }
