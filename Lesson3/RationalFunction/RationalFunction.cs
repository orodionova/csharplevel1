using System;
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
    public class RationalFunction
    {
        public int Dividend { get; set; }
        public int Divider { get; set; }
        private int nod;
        public double Decimal
        {
            get
            {
                return (double) Dividend / Divider;
            }
        }
        public RationalFunction(int dividend, int divider)
        {
            if(divider == 0)
            {
                throw new ArgumentException("The denominator cannot be 0");
            }
            Dividend = dividend;
            Divider = divider;
            nod = NOD(dividend, divider);
        }
        public RationalFunction()
        {
            Dividend = 0;
            Divider = 1;
        }
        public RationalFunction Plus(RationalFunction x)
        {
            var divider = Divider * x.Divider;
            var dividend = (divider / Divider) * Dividend + (divider / x.Divider) * x.Dividend;
            return new RationalFunction(dividend, divider);
        }
        public RationalFunction Minus(RationalFunction x)
        {
            var divider = Divider * x.Divider;
            var dividend = (divider / Divider) * Dividend - (divider / x.Divider) * x.Dividend;
            return new RationalFunction(dividend, divider);
        }
        public RationalFunction Multi(RationalFunction x)
        {
            var divider = Divider * x.Divider;
            var dividend = Dividend  * x.Dividend;
            return new RationalFunction(dividend, divider);
        }
        public RationalFunction Division(RationalFunction x)
        {
            if(x.Dividend == 0)
            {
                throw new ArgumentException("The dividend 2 cannot be 0");
            }
            var divider = Divider * x.Dividend;
            var dividend = Dividend * x.Divider;
            return new RationalFunction(dividend, divider);
        }
        public override string ToString()
        {
            if(nod != 1)
            {
                Dividend = Dividend / nod;
                Divider = Divider / nod;
                nod = 1;
            }
            return Dividend + "/" + Divider;
        }
        public string ToString(RationalFunction x, string operation)
        {
            return "(" + this.ToString() + ") " + operation + " (" + x.ToString() + ") =";
        }
        private int NOD(int num1, int num2) //НОД двух чисел равен последнему, неравному нулю остатку в алгоритме Евклида. 
        {
           if(num2 != 0)
            {
                if (num1 > num2) return NOD(num2, num1 % num2);
                else if (num1 < num2)  return NOD(num1, num2 % num1);
            }
            return num1;
        }
    }
}
