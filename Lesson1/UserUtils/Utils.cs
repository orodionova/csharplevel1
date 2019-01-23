using System;
/*
Родионова О.В.
Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause)
*/


namespace UserUtils
{
    public class Utils
    {
        public static void Pause()
        {
            Console.ReadLine();
        }
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
        public static void Print(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
    }
}
