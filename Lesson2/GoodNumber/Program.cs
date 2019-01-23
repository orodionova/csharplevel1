using System;
using UserUtils;
/*
 * Родионова О.В.
 * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
 * Хорошим называется число, которое делится на сумму своих цифр.
 * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */
namespace GoodNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var min = 1;
            var max = 1000000000;
            var begin = DateTime.Now;
            var count = GetCountGooNumber(min, max);
            var end = DateTime.Now;
            var diff = (end - begin).TotalSeconds;
            Utils.Print($"Count = {count}; Time in seconds {diff}");
            Utils.Pause();
        }
        private static int GetCountGooNumber(int min, int max)
        {
            var count = 0;
            for (var i = min; i <= max; i++)
            {
                var sum = 0;
                var number = i;
                while (number != 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                if (i % sum == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
