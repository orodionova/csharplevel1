using System;
using UserUtils;

/*
 * Родионова О.В.
 * С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 */

namespace SumOddPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.Print("Write integer! 0 - exit");
            var sum = GetSum();
            Utils.Print($"Sum of odd positive = {sum}");
            Utils.Pause();
        }

        private static int GetSum()
        {
            var sum = 0;
            var number = -1;
            while (number != 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0 && number % 2 != 0)
                    {
                        sum += number;
                    }
                }
                else
                {
                    Utils.Print("Not a integer!");
                    break;
                }
            }
            return sum;
        }
    }
}
