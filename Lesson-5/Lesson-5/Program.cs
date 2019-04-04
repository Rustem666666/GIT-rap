using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Иматдинов
//
//Задача 1.
//Создать программу, которая будет проверять корректность ввода логина.Корректным
//логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
//или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) ** с использованием регулярных выражений.

namespace Lesson_5
{
    class Program
    {
        static void Main()
        {
            bool success;
            do
            {
                success = true;
                Console.ResetColor();
                Console.WriteLine("Введите логин: ");
                char[] b = Console.ReadLine().ToCharArray();

                //Проверки
                if (b.Length < 2 || b.Length > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный логин. Количество символов должно быть от 2 до 10 символов.");
                    success = false;
                }
                if ((int)b[0] >= 48 && (int)b[0] <= 57)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный логин. Логин не может начинаться с цифры.");
                    success = false;
                }

                for (int i = 0; i < b.Length; i++)
                {
                    if ((int)b[i] >= 1040 && (int)b[i] <= 1103)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный логин. Логин не должен содержать символов кириллицы.");
                        success = false;
                        break;
                    }
                }
            } while (success != true);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы успешно зарегистрированы!");

            //С помощью регулярных выражений. Работает не совсем корректно, но работает.
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Введите логин: ");
            Regex regex = new Regex("[0-9A-Za-z]{2,10}");
            if (regex.IsMatch(Console.ReadLine()))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы успешно зарегистрированы!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный логин.");
            }
            


        }
    }
}
