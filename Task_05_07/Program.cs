using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Sources;

namespace Task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int n = int.Parse(Console.ReadLine());
            int min = 100;

            int[,] user = new int[n, n];

            for (int i = 0; i < user.GetLength(0); i++)
            {
                for (int j = 0; j < user.GetLength(1); j++)
                {
                    user[i, j] = random.Next(10, 100);
                    if (user[i, j] < min)
                    {
                        min = user[i, j];
                    }
                    Console.Write(user[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine();



            for (int i = 0; i < user.GetLength(0); i++)
            {
                for (int j = 0; j < user.GetLength(1); j++)
                {
                    user[i, j] *= min;
                }
            }

            for (int i = 0; i < user.GetLength(0); i++)
            {
                for (int j = 0; j < user.GetLength(1); j++)
                {
                    Console.Write(user[i, j] + "\t");
                }
                Console.WriteLine();



            }

            Console.WriteLine("\n\n");


            //5 максимальных элементов
            bool[,] maxValues = new bool[n, n];



            for (int d = 0; d < 5; d++)
            {
                int tempMax = 0;
                int iMax = 0;
                int jMax = 0;
                for (int i = 0; i < user.GetLength(0); i++)
                {
                    for (int j = 0; j < user.GetLength(1); j++)
                    {
                        if (user[i, j] > tempMax && maxValues[i, j] == false)

                        {
                            tempMax = user[i, j];
                            iMax = i;
                            jMax = j;
                        }
                    }
                }
                maxValues[iMax, jMax] = true;
                Console.WriteLine("индексы максимального значения: " + iMax + " " + jMax);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (maxValues[i, j] == true)
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



                    //        for (int i = use)

                    //int[] maxV = new int[5];
                    //for (int i = 0; i < n; i++)
                    //{
                    //    for (int j = 0; j < n; j++)
                    //    {
                    //        for(int k = 0; k < maxV.Length; k++)
                    //        {
                    //            if (user[i, j] > maxV[k])
                    //            {
                    //                for (int l = maxV.Length -1; l > k; l--)
                    //                {
                    //                    maxV[l] = maxV[l - 1];
                    //                }
                    //            }
                    //            maxV[k] = user[i, j];
                    //            break;
                    //        }


                    //    }
                    //}
                    //вывод матрицы

                    //for (int i = 0; i < user.GetLength(0); ++i)
                    //{
                    //    for (int j = 0; j < user.GetLength(1); ++j)
                    //    {
                    //        for ( int k = 0; k < maxV.Length; k++)
                    //        {
                    //            if (user[i, j] == maxV[k])
                    //            {
                    //                Console.ForegroundColor = ConsoleColor.Green;
                    //                Console.Write(user[i, j] + "\t");
                    //                Console.ResetColor();
                    //            }
                    //            else
                    //            {
                    //                Console.Write(user[i, j] + "\t");
                    //            }
                    //        }
                    //        Console.WriteLine();
                    //    }

                    //} 



                }
    }
