using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
#pragma warning disable

    internal class Journal
    {
        public string title; 
        public string data;
        public string naprav;
        public int str;
        public int manny;        
        
        public void GetInfo()
        {
            Console.WriteLine($"Название журнала: '{title}'");
            Console.WriteLine($"Дата издания: {data}");
            Console.WriteLine($"Предметно-тематическая направленность журнала: '{naprav}'");
            Console.WriteLine($"Количество страниц: {str}");
            Console.WriteLine($"Цена: {manny}");
        }
        public void Buy()
        {
            Console.WriteLine($"Введите 'buy' если хотите купить журнал\n Цена журнала: {manny} ");
            string user = Console.ReadLine();
            if (user == "buy")
            {
                Console.WriteLine("Куплена");
            }
            else
            {
                Console.WriteLine("Не куплена");
            }
        }
        public void Soder()
        {
            Console.WriteLine("Содержание журнала");
            Console.WriteLine("1. Роль скандинавского язычества в формировании культуры викингов\n2. Скандинавские божества, космогонические мифы и создание мира \n3. Обряды скандинавского культа\n4. Мировоззрение скандинавского язычества");
        }
    }

}



