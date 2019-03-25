using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        /// <summary>
        /// Возвращает минимальное из трёх чисел.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static double Getmin(double a, double b, double c)
        {
            double max = a;
            if (b > max) { max = b; }
            if (c > max) { max = c; }

            return max;
        }

        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите два целых числа.");
            Console.Write("Первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Третье число:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Наибольшее число {0}", Getmin(a, b, c));
            Console.ReadLine();
        }
    }
}
