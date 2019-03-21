using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обмен значений с использованием третьей переменной
            int a, b, c;
            Console.WriteLine("Обмен значений с использованием третьей переменной.");
            Console.WriteLine("Введите значение a: ");
            a = Convert.ToInt32(Console.ReadLine());     // Присваиваем начальное значение a
            Console.WriteLine("Введите значение b: ");
            b = Convert.ToInt32(Console.ReadLine());     // Присваиваем начальное значение b
            c = a;      // В c запоминаем значение a
            a = b;      // В a записываем b
            b = c;      // В b записываем сохраненное a
            Console.WriteLine($"Новое значение a={a},b={b}.");
            Console.ReadLine();

            //Обмен значений без использования третьей переменной
            Console.WriteLine("Обмен значений без использования третьей переменной.");
            Console.WriteLine("Введите значение a: ");
            a = Convert.ToInt32(Console.ReadLine());     // Присваиваем начальное значение a
            Console.WriteLine("Введите значение b: ");
            b = Convert.ToInt32(Console.ReadLine());     // Присваиваем начальное значение b
            a = a + b;  // Присваиваем a сумму значений a и b
            b = a - b;  // Присваиваем b разность между новым значением a и переменной b
            a = a - b;  // Присваиваем a результат вычитания b из обновленного значения a. Готово
            Console.WriteLine($"Новое значение a={a},b={b}.");
            Console.ReadLine();

        }
    }
}
