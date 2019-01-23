using System;
using UserUtils;
/*
 * Родионова О.В.
 * Написать метод, возвращающий минимальное из трех чисел.
 */
namespace MinFromThreeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 20;
            var c = 30;
            WriteNumber(a, b, c);
            Utils.Print("Min first");
            Utils.Print("Min = " + Min(a, b, c));
            Utils.Print("MinMath = " + MinMath(a, b, c));
            b = 8;
            WriteNumber(a, b, c);
            Utils.Print("Min middle");
            Utils.Print("Min = " + Min(a, b, c));
            Utils.Print("MinMath = " + MinMath(a, b, c));
            c = 3;
            WriteNumber(a, b, c);
            Utils.Print("Min last");
            Utils.Print("Min = " + Min(a, b, c));
            Utils.Print("MinMath = " + MinMath(a, b, c));
            Utils.Pause();

        }
        private static double Min(double a, double b, double c)
        {
            var min = a;
            if(min > b) min = b;
            if(min > c) min = c;
            return min;
        }
        private static double MinMath(double a, double b, double c)
        {
            var min = Math.Min(Math.Min(a, b), c);
            return min;
        }
        private static void WriteNumber(double a, double b, double c)
        {
            Utils.Print($"a = {a}; b = {b}; c = {c}");
        }
    }
}
