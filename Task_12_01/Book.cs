using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
#pragma warning disable

    internal class Book
    {
        public string title; //поле класса - хранит название книги
        public string autor; //поле класса - хранит автора книги
        bool isReading = false; //поле класса - хранит статус книги (выдана ли она читателю)

        //метод класса - печатает в консоль информацию о книге
        public void GetInfo()
        {
            Console.WriteLine($"{autor} : {title}");
        }
        //метод класса - выдает книгу читателю и ставит отметку о выдаче
        public void GetBoot()
        {
            if (isReading)
                Console.WriteLine($"книга {title} в данный момент выдана другому читателю");
            else
            {
                isReading = true;
                Console.WriteLine("книга выдана на неделю");
            }
        }

    }
    public class Book1
    {
        public string Title { get; private set; }
        public bool IsAvailable { get; private set; }

        public Book1(string title)
        {
            Title = title;
            IsAvailable = true; 
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Книга '{Title}' была взята.");
            }
            else
            {
                Console.WriteLine($"Книга '{Title}' недоступна.");
            }
        }

        public void ReturnBook()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"Книга '{Title}' была возвращена и теперь доступна.");
            }
            else
            {
                Console.WriteLine($"Книга '{Title}' уже доступна.");
            }
        }
    }
}


