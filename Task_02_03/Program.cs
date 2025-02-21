using Microsoft.VisualBasic;

namespace Task_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login username = new Login();
            string usernamelog = username.login;
            string usernamepass = username.password;
            
            Console.WriteLine("Был произведен вход в программу");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Что хотите сделать?\n1. Регистрация\n2. Сменить логин\n3. Сменить пароль\n4. Выйти из программы");
                Console.Write("Введите цифру действия: ");
                string us = Console.ReadLine();
                Console.WriteLine();
                if (us == "1")
                {
                    username.Register();
                    Console.WriteLine();
                    Console.WriteLine("Вы зарегестрированы!");
                    Console.WriteLine("--------------------------------------");

                }
                else if (us == "2")
                {
                    username.LogNew();
                    Console.WriteLine();
                    Console.WriteLine("Логин изменен");
                    Console.WriteLine("--------------------------------------");
                }
                else if (us == "3")
                {
                    username.PassNew();
                    Console.WriteLine();
                    Console.WriteLine("Пароль изменен");
                    Console.WriteLine("--------------------------------------");
                }
                else if (us == "4")
                {
                    Console.WriteLine("Thank you!");
                    break;
                }
                else
                {
                    Console.WriteLine("Error");
                    break;
                }
                    Console.WriteLine();
                
            }
        }
    }
}
