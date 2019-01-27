using System;
using UserUtils;
/*
 * Родионова О.В.
 * *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
 *  Предусмотреть методы сложения, вычитания, умножения и деления дробей.
 *  Написать программу, демонстрирующую все разработанные элементы класса.
 * * Добавить свойства типа int для доступа к числителю и знаменателю;
 * * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
 * ** Добавить проверку, чтобы знаменатель не равнялся 0. 
 *    Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
 * *** Добавить упрощение дробей.
 * 
 */
namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dend1, der1, dend2, der2;
            Utils.Print("Write first Rational Function");
            Utils.Print("dividend");
            dend1 = Console.ReadLine();
            Utils.Print("divider");
            der1 = Console.ReadLine();
            Utils.Print("Write second Rational Function");
            Utils.Print("dividend");
            dend2 = Console.ReadLine();
            Utils.Print("divider");
            der2 = Console.ReadLine();
            int dividend1, dividend2, divider1, divider2;
            if (Int32.TryParse(dend1, out dividend1) && Int32.TryParse(der1, out divider1)
                && Int32.TryParse(dend2, out dividend2) && Int32.TryParse(der2, out divider2))
            {
                var ratFunc1 = new RationalFunction(dividend1, divider1);
                var ratFunc2 = new RationalFunction(dividend2, divider2); ;
                Utils.Print("Write operation +, -, *, /");
                var operation = Console.ReadLine();
                var result = new RationalFunction();
                Utils.Print(ratFunc1.ToString(ratFunc2, operation));
                switch (operation)
                {
                    case "+":
                        result = ratFunc1.Plus(ratFunc2);
                        Utils.Print(result.ToString());
                        break;
                    case "-":
                        result = ratFunc1.Minus(ratFunc2);
                        Utils.Print(result.ToString());
                        break;
                    case "*":
                        result = ratFunc1.Multi(ratFunc2);
                        Utils.Print(result.ToString());
                        break;
                    case "/":
                        result = ratFunc1.Division(ratFunc2);
                        Utils.Print(result.ToString());
                        break;
                    default:
                        Utils.Print("Operation does not exist");
                        break;
                }
            }
            else
            {
                Utils.Print("Input Error");
            }
            
            Utils.Pause();
        }
    }
}
