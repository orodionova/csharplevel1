using System;
using UserUtils;
/*
 * Родионова О.В.
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
 * б) Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */
namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.Print("Write integer a and b (a<b): ");
            Utils.Print("a: ");
            var aStr = Console.ReadLine();
            Utils.Print("b: ");
            var bStr = Console.ReadLine();
            int a;
            int b;
            if (Int32.TryParse(aStr, out a) && Int32.TryParse(bStr, out b) && a < b)
            {
                Utils.Print("Numbers");
                NumberBetween(a, b);
                var sum = 0;
                sum = GetNumberSum(a, b, sum);
                Utils.Print($"Sum = {sum}");
            }
            else
            {
                Utils.Print("Values entered are not correct.");
            }
            Utils.Pause();

        }
        private static void NumberBetween(int a, int b)
        {
            if(a <= b)
            {
                Utils.Print(a.ToString());
                a++;
                NumberBetween(a, b);
            }
        }
        private static int GetNumberSum(int a, int b, int sum)
        {
            if (a <= b)
            {
                sum = sum + a;
                a++;
                return GetNumberSum(a, b, sum);
            }
            return sum;
        }
    }
}
