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
            //Вводим данные
            double a, b, c, d;
            Console.Write("Ваш рост (см): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ваш вес (кг): ");
            b = Convert.ToDouble(Console.ReadLine());
            //Приводим к системе СИ
            c = a / 100;

            //Рассчитываем ИМТ
            d = b / (c * c);

            //Выводим данные со знаком $
            Console.WriteLine($"При росте человека равным {a} см и весе {b} кг индекс масы тела равен {d:F2} кг/м2.");
            Console.ReadLine();
        }
    }
}
