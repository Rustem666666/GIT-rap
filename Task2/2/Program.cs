using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в котором нужно подсчитать количество цифр:   ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(a));
        }

        /// <summary>
        /// Возвращает количество цифр в числе
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static long Sum(long a)               // нерекурсивный метод
        {
            int count = (a == 0) ? 1 : 0;   // если условие a = 0 имеет значение true, возвращает 1, в противном случае и возвращает 0
            while (a != 0)                  // пока a больше нуля
            {
                count++;
                a /= 10;          // отбрасываем от числа а последнюю цифру
            }
            return count;                     // возвращаем в качестве результата сумму цифр числа a
        }

    }
}
