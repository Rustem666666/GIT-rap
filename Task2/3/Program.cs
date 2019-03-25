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
        /// Возвращает true если число чётное
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static bool Check(int a)
        {
            if (a % 2 == 0) return false; else return true;
        }

        static void Main()
        {
            int a = 0;
            List<int> numbers = new List<int>() { };

            //Ввод чисел до тех пор, пока не будет введён ноль
            do
            {
                Console.Write("Введите число:   ");
                a = Convert.ToInt32(Console.ReadLine());
                numbers.Add(a);                          // добавление элемента

            }
            while (a > 0);

            //Выводим введённые числа
            Console.Write("Числа " );

            a = 0; //Обнуляем a, так как будет использоваться в качестве ответа

            //Отбираем из них только чётные
            foreach (int i in numbers)
            {
                if (Check(i) && i != 0)
                {
                    Console.Write(i + " ");
                    a = a + i;
                }
            }
            Console.WriteLine("Сумма нечётных чисел из списка = " + a + ".");
            Console.ReadLine();

        }

    }
}
