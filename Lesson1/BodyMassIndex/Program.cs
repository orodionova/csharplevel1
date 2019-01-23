using System;

/*
Родионова О.В. 
 Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле /k’I
=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
*/
namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваш рост(см): ");
            var heightStr = Console.ReadLine();
            Console.Write("Ваш вес(кг): ");
            var weightStr = Console.ReadLine();
            double height;
            double weight;
            if(Double.TryParse(heightStr, out height) && Double.TryParse(weightStr, out weight))
            {
                var index = weight / Math.Pow(height/100, 2);
                Console.WriteLine("Индекс массы тела: {0:N2}.", index);
            }
            else
            {
                Console.WriteLine("Невозможно обработать введенные значения");
            }
            Console.ReadLine();
        }
    }
}
