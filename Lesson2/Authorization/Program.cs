using System;
using UserUtils;
/*
 * Родионова О.В.
 * Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу:
 * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 */
namespace Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            var isLogin = false;
            var countChance = 0;
            do
            {
                Utils.Print("Login");
                var login = Console.ReadLine();
                Utils.Print("Password");
                var password = Console.ReadLine();
                isLogin = IsLogin(login, password);
                if (isLogin) break;
                Utils.Print("Incorrect login or password");
                countChance++;
            }
            while (countChance != 3);
            if(isLogin)
            {
                Utils.Print("Success login");
            }
            else
            {
                Utils.Print("Try later");
            }
            Utils.Pause();
        }

        private static bool IsLogin(string login, string password)
        {
            var loginRight = "root";
            var passRight = "GeekBrains";
            if (login == loginRight && password == passRight)
            {
                return true;
            }
            return false;
        }

    }
}
