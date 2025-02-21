using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_03
{
    class Login
    {
        public string login;
        public string password;

        public void Register()
        {
            
            Console.Write("Ввведите логин: ");
            string userlog = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string userpass = Console.ReadLine();
        }
        public void PassNew()
        {
            Console.Write("Введите новый пароль: ");
            string userpass = Console.ReadLine();
        }
        public void LogNew()
        {
            Console.Write("Ввведите новый логин: ");
            string userlog = Console.ReadLine();
        }
    }
}
