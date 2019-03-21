using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводим данные
            Console.Write("Ваше имя:");
            string a = Console.ReadLine();
            Console.Write("Ваша фамилия:");
            string b = Console.ReadLine();
            Console.Write("Ваш возраст:");
            string c = Console.ReadLine();
            Console.Write("Ваш рост:");
            string d = Console.ReadLine();
            Console.Write("Ваш вес:");
            string e = Console.ReadLine();
            //Выводим данные склеиванием
            Console.WriteLine(a + " " + b + ". Возраст " + c + " лет. Рост " + d + " см. Вес " + e + " кг.");
            Console.ReadLine();
            //Выводим данные форматированием
            Console.WriteLine("{0} {1}. Возраст {2} лет. Рост {3} см. Вес {4} кг.", a, b, c, d, e);
            Console.ReadLine();
            //Выводим данные со знаком $
            Console.WriteLine($"{a} {b}. Возраст {c} лет. Рост {d} см. Вес {e} кг.");
            Console.ReadLine();
        }
    }
}
