using System;
/* Родионова О.В.
Написать программу обмена значениями двух переменных:
	а) с использованием третьей переменной;
	б) *без использования третьей переменной.
*/
namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 9;
            Console.WriteLine($"a = {a}; b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Поменять местами значения двух целочисленных переменных с использованием третьей: a = {a}; b = {b}");
            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            Console.WriteLine($"Поменять обратно значения двух целочисленных переменных без использования третьей: a = {a}; b = {b}");
            Console.ReadLine();
        }
    }
}
