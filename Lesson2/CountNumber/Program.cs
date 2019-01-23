using UserUtils;
using System;
/*
 * Родионова О.В.
 * Написать метод подсчета количества цифр числа.
 */

namespace CountNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1234137875;
            Utils.Print($"Number Of Digits {a}");
            Utils.Print(NumberOfDigits(a).ToString());
            Utils.Pause();
        }
        private static int NumberOfDigits(int number)
        {
            number = Math.Abs(number);
            return number.ToString().Length;
        }
    }
}
