using System;
using UserUtils;

/*
 * Родионова О.В.
 * а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
 *  нужно ли человеку похудеть, набрать вес или все в норме;
 * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */
namespace BodyMassIndex
{
    class Program
    {
        enum IndexResult
        {
            Low,
            Norm,
            High
        };

        static void Main(string[] args)
        {
            Utils.Print("Ваш рост(см): ");
            var heightStr = Console.ReadLine();
            Utils.Print("Ваш вес(кг): ");
            var weightStr = Console.ReadLine();
            double height;
            double weight;
            if (Double.TryParse(heightStr, out height) && Double.TryParse(weightStr, out weight))
            {
                var index = GetIndex(height, weight);
                Utils.Print("Индекс массы тела: " + index.ToString("0.00"));
                var indexResult = GetIndexResult(index);
                Utils.Print(GetReccomend(indexResult));
                if(indexResult != IndexResult.Norm)
                {
                    Utils.Print(GetAccurateReccomend(indexResult, index, height, weight));
                }
            }
            else
            {
                Utils.Print("Невозможно обработать введенные значения");
            }
            Utils.Pause();
        }
        private static double GetIndex(double height, double weight)
        {
            return weight / Math.Pow(height / 100, 2);
        }
        private static IndexResult GetIndexResult(double index)
        {
            if (index <= 18.5) return IndexResult.Low;
            else if (index < 25) return IndexResult.Norm;
            else return IndexResult.High;
        }

        private static string GetAccurateReccomend(IndexResult indexResult, double index, double height, double weight)
        {
            var reccomend = "";
            double mas = 0;
            var div = Math.Pow(height / 100, 2);
            switch (indexResult)
            {
                case IndexResult.Low:
                    mas = (18.51 - index) * div; 
                    reccomend = "Вам необходимо наборать " + mas.ToString("0.00") + " кг";
                    break;
                case IndexResult.High:
                    mas = (index - 25) * div;
                    reccomend = "Вам необходимо скинуть " + mas.ToString("0.00") + " кг";
                    break;
            };
            return reccomend;
        }

        private static string GetReccomend(IndexResult indexResult)
        {
            var reccomend = "";
            switch(indexResult)
            {
                case IndexResult.Low:
                    reccomend = "Дефицит массы тела";
                    break;
                case IndexResult.Norm:
                    reccomend = "Вес в норме";
                    break;
                default:
                    reccomend = "Избыточная масса тела";
                    break;
            };
            return reccomend;
        }
    }
}
