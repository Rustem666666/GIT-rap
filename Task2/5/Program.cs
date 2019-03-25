using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        /// <summary>
        /// Возвращает число соответствующее текущей рекомендации по нормализации ИМТ
        /// </summary>
        /// <param name="imt"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        static void imtNormal(double imt, double max, double min)
        {
            double g = 0;
            if (imt >= min && imt <= max)
            {
                Console.ForegroundColor = ConsoleColor.Green; //Меняем цвет для красоты
                Console.WriteLine("Поздравляем, ваш ИМТ в норме.");
            }
            else
            {
                if (imt < min)
                {
                    g = (min - imt) + 1;
                    Console.ForegroundColor = ConsoleColor.Red; //Меняем цвет для красоты
                    Console.WriteLine($"Ваша ситуация плачевная. Для нормализации ИМТ вам нужно набрать {g:F0} кг.");
                }
                else
                {
                    if (imt > max)
                    {
                        g = (imt - max) - 1;
                        Console.ForegroundColor = ConsoleColor.Red; //Меняем цвет для красоты
                        Console.WriteLine($"Мы должны вас расстроить. Для нормализации ИМТ вам нужно похудеть на {g:F0} кг.");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            double m, h, hsi, imt; // масса, рост, рост в системе СИ, ИМТ соответственно
            string p; // пол
            //Ввод данных
            Console.WriteLine("Приветствуем вас в программе по рассчёту Индекса массы вашего тела.");
            Console.WriteLine();
            Console.Write("Введите свой вес (кг):     ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост (см):     ");
            h = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.Write("Для того чтобы всё правильно рассчитать нам нужно узнать ваш пол (м\\ж):     ");
                p = Console.ReadLine();
            } while (p != "м" && p != "ж");

            //Приводим рост системе СИ (см в м)
            hsi = h / 100;

            //Рассчитываем ИМТ
            imt = m / (hsi * hsi);

            Console.WriteLine();
            Console.WriteLine($"Индекс массы вашего тела при весе {m} кг и росте {h:F0} см равен {imt:F2} кг/м2.");
            Console.WriteLine("Индекс массы тела для женщин считается нормальным, если показатель входит в диапазон от 20 до 22.");
            Console.WriteLine("Для мужчин этот показатель должен быть от 23 до 25.");
            Console.WriteLine();
            if (p == "м")
            {
                imtNormal(imt, 25, 23);
            }
            else if (p == "ж")
            {
                imtNormal(imt, 22, 20);
            }
        }
    }
}
