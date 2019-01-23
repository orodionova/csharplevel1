using System;

/*Родионова О.В. Расстояние между двумя точками
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
*/

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Координаты первой точки: x1 = ");
            var x1Str = Console.ReadLine();
            Console.Write("y1 = ");
            var y1Str = Console.ReadLine();
            Console.Write("Координаты второй точки: x2 = ");
            var x2Str = Console.ReadLine();
            Console.Write("y2 = ");
            var y2Str = Console.ReadLine();
            double x1, x2, y1, y2;
            if(Double.TryParse(x1Str, out x1) && Double.TryParse(x2Str, out x2) 
                && Double.TryParse(y1Str, out y1) && Double.TryParse(y2Str, out y2))
            {
                var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine($"Расстояние между двумя точками ({x1};{y1}) и ({x2};{y2}): {distance:f2}");
                var distanceFromMethod = DistanceBetweenTwoPoints(x1, y1, x2, y2);
                Console.WriteLine($"Рассчет в методе. Расстояние между двумя точками ({x1};{y1}) и ({x2};{y2}): {distanceFromMethod:f2}");
            }
            else
            {
                Console.WriteLine("Невозможно обработать введенные значения");
            }
            Console.ReadLine();
        }
        private static double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }
}
