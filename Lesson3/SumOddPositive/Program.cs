using System;
using UserUtils;

/*
 * Родионова О.В.
 * а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечётных положительных чисел. 
 * Сами числа и сумму вывести на экран, используя tryParse.
 */

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.Print("Write integer! 0 - exit");
            var sum = 0;
            var number = -1;
            var numberSumString = "0";
            while (number != 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    GetSum(number, ref sum);
                    GetNumberSumString(number, ref numberSumString);
                }
                else
                {
                    throw new ArgumentException("Not a integer!");
                }
            }
            Utils.Print("Sum of odd positive:");
            Utils.Print($"{numberSumString}  = {sum}");
            Utils.Pause();
        }
        private static void GetNumberSumString(int number, ref string numberSum)
        {
            if (IsOddPositive(number))
            {
                if (numberSum == "0")
                {
                    numberSum = number.ToString();
                }
                else
                {
                    numberSum += " + " + number.ToString();
                }
            }
        }
        private static void GetSum(int number, ref int sum)
        {
            if (IsOddPositive(number))
            {
                sum += number;
            }
        }
        private static bool IsOddPositive(int number)
        {
            return number > 0 && number % 2 != 0;
        }
    }
}
