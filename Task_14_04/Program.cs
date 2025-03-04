using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;

namespace Task_14_04
{
    /*Определите класс User, который будет иметь статическое свойство CurrentUser,
     * представляющее текущего пользователя, и метод для его установки
     */
    internal class User
    {
        public string name;
        public string firstname;
        public int age;
        public int id;
        public string email;

    }
    internal class Program
    {
        public static void CurrentUser()
        {
            User vc = new User();
            string Name = vc.name;
            string Firstname = vc.firstname;
            int Age = vc.age;
            int ID = vc.id;
            string Email = vc.email;

            Name = "Данила";
            Firstname = "Бодров";
            Age = 34;
            ID = 230575;
            Email = "danilabodrov56@gmail.com";

            Console.WriteLine("Пользователь:");
            Console.WriteLine();
            Console.Write(Name + " ");
            Console.WriteLine(Firstname);
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"id: {ID}");
            Console.WriteLine($"Email: {Email}");
        }
        static void Main(string[] args)
        {
            CurrentUser();
        }
        
    }
}
    

