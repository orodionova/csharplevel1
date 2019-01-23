using System;
using UserUtils;
/*
Родионова О.В.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
*/

namespace MyData
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = "Ольга Родионова Нижний Новгород";
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            Print(data);
            Console.ReadLine();
            Console.Clear();
            //б) *Сделать задание, только вывод организовать в центре экрана.
            PrintInCenter(data);
            Console.ReadLine();
            Console.Clear();
            //в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            Print(data, 50, 5);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Методы из задания 6");
            Utils.Pause();
            Console.Clear();
            Utils.Print(data);
            Utils.Print(data, 7, 8);
            Utils.Pause();

        }

        private static void Print(string text)
        {
            Console.WriteLine(text);
        }
        private static void Print(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
        private static void PrintInCenter(string text)
        {
            var paddingLeft = Console.WindowWidth / 2 - text.Length / 2;
            var paddingTop = Console.WindowHeight / 2 - 1;
            Console.SetCursorPosition(paddingLeft, paddingTop);
            Console.WriteLine(text);
        }
    }
}
