using System;
/*
 * Родионова О.В.
 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 * в) Добавить диалог с использованием switch демонстрирующий работу класса.
 */
namespace Lesson3
{
    struct Complex
    {
        public double im;
        public double re;
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public Complex Division(Complex x)
        {
            if (x.re == 0 && x.im == 0)
            {
                throw new ArgumentException("Parameter cannot be null", "x");
            }
            var divider = x.im * x.im + x.re * x.re;
            Complex y;
            y.re = (re * x.re + im * x.im) / divider;
            y.im = (x.re * im - x.im * re) / divider;
            return y;

        }
        override public string ToString()
        {
            var sign = im >= 0 ? "+" : "";
            return re.ToString("0.##") + sign + im.ToString("0.##") + "i";
        }
        public string ToString(Complex x, string operation)
        {
            return "(" + this.ToString() + ") " + operation + " (" + x.ToString() + ")";
        }
    }

}
