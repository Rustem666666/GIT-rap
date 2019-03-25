using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        /// <summary>
        /// Возвращает true если логин и пароль введены верно.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static bool checkLogin(string a, string b)
        {
            if (a == "root" && b == "GeekBrains") return true; return false;
        }

        static void Main(string[] args)
        {
            string lg, pw;
            int tryCount = 0; //Вводим переменную количества попыток
            do
            {
                //Ввод данных
                Console.Write("Введите логин:     ");
                lg = Console.ReadLine();
                Console.Write("Введите пароль:     ");
                pw = Console.ReadLine();
                
                //Проверка с помощью метода checkLogin
                if (checkLogin(lg, pw))
                {
                    Console.ForegroundColor = ConsoleColor.Green; //Меняем цвет для красоты
                    Console.Write("             Приветствуем вас на сайте GeekBrains!!!");
                    break;
                }
                else
                {
                    tryCount++; //Плюс один к количеству попыток
                    Console.WriteLine("             Данные введены неверно.");

                    if (tryCount >= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; //Меняем цвет для красоты
                        Console.Write("             Доступ заблокирован.");
                    }
                    else
                    {
                        Console.WriteLine("             Попробуйте ещё раз.");
                    }
                }
            } while (tryCount != 3);
            Console.ReadLine();


        }
    }
}
