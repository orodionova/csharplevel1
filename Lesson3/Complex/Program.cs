using System;
using UserUtils;
/*
 * Родионова О.В.
 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 * в) Добавить диалог с использованием switch демонстрирующий работу класса.
 */
namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string re1, im1, re2, im2;
            Utils.Print("Write first complex number");
            Utils.Print("re");
            re1 = Console.ReadLine();
            Utils.Print("im");
            im1 = Console.ReadLine();
            Utils.Print("Write second complex number");
            Utils.Print("re");
            re2 = Console.ReadLine();
            Utils.Print("im");
            im2 = Console.ReadLine();
            Complex complex1;
            Complex complex2;
            if (Double.TryParse(re1, out complex1.re) && Double.TryParse(im1, out complex1.im)
                && Double.TryParse(re2, out complex2.re) && Double.TryParse(im2, out complex2.im))
            {
                Utils.Print("Write operation +, -, *, /");
                var operation = Console.ReadLine();
                Complex result;
                Utils.Print(complex1.ToString(complex2, operation));
                switch (operation)
                {
                    case "+":
                        result = complex1.Plus(complex2);
                        Utils.Print(result.ToString());
                        break;
                    case "-":
                        result = complex1.Minus(complex2);
                        Utils.Print(result.ToString());
                        break;
                    case "*":
                        result = complex1.Multi(complex2);
                        Utils.Print(result.ToString());
                        break;
                    case "/":
                        result = complex1.Division(complex2);
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
