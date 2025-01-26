using System.Threading.Channels;

namespace Task_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее
                  количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
                  отдельно вывести дни без осадков. Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
                  осадков, до 300 мм выпавших осадков
                   */


            Random rnd = new Random();
            int[] tem = new int[30];
            int summ = 0;

            for (int i = 0; i < tem.Length; i++)
            {

                tem[i] = rnd.Next(0, 301);

            }

            Console.WriteLine("Осадки за каждый день месяца: ");

            for (int i = 0; i < tem.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {tem[i]}");
                summ += tem[i];
            }
            Console.WriteLine($"Общее количество осадков: " + summ);

            for (int decade = 0; decade < 3; decade++)
            {
                int start = decade * 10;
                int totalPrecipitation = 0;

                for (int day = start; day < start + 10; day++)
                {
                    totalPrecipitation += tem[day];
                }

                Console.WriteLine($"Общее количество осадков за {decade + 1} декаду: {totalPrecipitation} мм");
            }

            int maxPrecipitation = 0;
            int maxDay = -1;

            for (int i = 0; i < tem.Length; i++)
            {
                if (tem[i] > maxPrecipitation)
                {
                    maxPrecipitation = tem[i];
                    maxDay = i + 1;
                }
            }

            Console.WriteLine($"День с самыми сильными осадками: День {maxDay} ({maxPrecipitation} мм)");

            for (int p = 0; p < tem.Length; p++)
            {
                if (tem[p] == 0)
                {
                    Console.WriteLine($"Дни без осадков: {p + 1} ");

                }


            }
        }
    }
}
        
    
