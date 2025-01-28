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


            Random random = new Random();
            int[] teme = new int[30];
            int sum = 0;

            for (int i = 0; i < teme.Length; i++)
            {

                teme[i] = random.Next(0, 301);

            }

            Console.WriteLine("Осадки за каждый день месяца: ");

            for (int i = 0; i < teme.Length; i++)
            {
                Console.WriteLine($"День {i + 1}: {teme[i]}");
                sum += teme[i];
            }
            Console.WriteLine($"Общее количество осадков: " + sum);

            for (int decade = 0; decade < 3; decade++)
            {
                int st = decade * 10;
                int totalPrecipitation = 0;

                for (int day = st; day < st + 10; day++)
                {
                    totalPrecipitation += teme[day];
                }

                Console.WriteLine($"Общее количество осадков за {decade + 1} декаду: {totalPrecipitation} мм");
            }

            int max = 0;
            int max1 = -1;

            for (int i = 0; i < teme.Length; i++)
            {
                if (teme[i] > max)
                {
                    max = teme[i];
                    max1 = i + 1;
                }
            }

            Console.WriteLine($"День с самыми сильными осадками: День {max1} ({max} мм)");

            for (int po = 0; po < teme.Length; po++)
            {
                if (teme[po] == 0)
                {
                    Console.WriteLine($"Дни без осадков: {po + 1} ");

                }


            }
        }
    }
}
        
    
