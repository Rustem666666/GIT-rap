using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Иматдинов

//Задача 4:
//Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
//Создайте структуру Account, содержащую Login и Password.
namespace Task4
{
    class Account
    {
        public string login;
        public string password;

        public Account()
        {
            login = "";
            password = "";
        }
        public Account(string lg, string pw)
        {
            login = lg;
            password = pw;
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { login = value; }
        }

        public static string[] ReadAccountFromFile(string filename)
        {
            string[] mass = new string[1];
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    int N = int.Parse(sr.ReadLine()); //Первая цифра в файле - количество аккаунтов. Дальше логин и пароль каждый с новой строки.
                    mass = new string[(N*2)+1];
                    for (int i = 1; i < (N * 2) + 1; i++)
                    {
                        mass[i] = sr.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не существует.");
            }
            //string s = "";
            //foreach (string v in mass)
            //    s = s + v + " ";
            //Console.WriteLine("Массив: \n" + s);
            return mass;
        }

    }
   
    class Program
    {
        //public static bool checkLogin(string a, string b)
        //{
        //    if (a == account1.Login && b == account1.Password) return true; return false;
        //}

        static void Main(string[] args)
        {
            string[] AccBase = Account.ReadAccountFromFile("data.txt");
            Account account1 = new Account(AccBase[1], AccBase[2]);
            Account account2 = new Account(AccBase[3], AccBase[4]);
            Account account3 = new Account(AccBase[5], AccBase[6]);
            Account account4 = new Account(AccBase[7], AccBase[8]);
            Account account5 = new Account(AccBase[9], AccBase[10]);
            Account account6 = new Account(AccBase[11], AccBase[12]);
            //Не смог разобраться как сделать этот процесс автоматическим. Топорно, но работает.

            string lg, pw;
            int tryCount = 0; //Вводим переменную количества попыток
            Console.WriteLine("             Здесь зашифровано сообщение!!!");
            do
            {
                //Ввод данных
                Console.Write("Введите логин:     ");
                lg = Console.ReadLine();
                Console.Write("Введите пароль:     ");
                pw = Console.ReadLine();

                //Проверка с помощью метода checkLogin
                if (lg == account1.Login && pw == account1.Password)
                {
                    Console.ForegroundColor = ConsoleColor.Green; //Меняем цвет для красоты
                    Console.Write("             Поздравляю, ваш логин и пароль успешно утекли в сеть!!!");
                    Console.ReadLine();
                    Console.Write("             Шутка. На самом деле программа больше ничего не умеет, кроме как выдавать это сообщение.");
                    Console.ReadLine();
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
