using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        /// <summary>
        /// Высчитывает расстояние между точками
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        static double S(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            //Вводим данные
            double x1, y1, x2, y2, r;
            x1 = 2;
            y1 = 3;
            x2 = 6;
            y2 = 7;

            //Рассчитываем расстояние
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Выводим данные со знаком $
            Console.WriteLine($"Расстояние между точками A({x1};{y1}) и B({x2};{y2}) равно {r:F2}.");
            Console.ReadLine();
            //Выводим данные со знаком $ с помощью метода
            Console.WriteLine($"Расстояние между точками A({x1};{y1}) и B({x2};{y2}) равно " + S(x1, y1, x2, y2));
            Console.ReadLine();

        }
    }
}
