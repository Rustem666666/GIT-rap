using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    /// <summary>
    /// Класс дроби, выполняет арифметические операции с дробями
    /// </summary>
    class Fraction
    {
        // Поля приватные.
        private double ma;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double pa;

        // Конструктор без параметров.
        public Fraction()
        {
            ma = 0;
            pa = 0;
        }
        // Конструктор, в котором задаем поля.
        
        public Fraction(double ma, double pa)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.
            this.ma = ma;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.pa = pa;
        }
        /// <summary>
        /// Возвращает результат сложения дробей
        /// </summary>
        /// <param name="x2"></param>
        /// <returns></returns>
        public Fraction Plus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.ma = x2.pa * ma + x2.ma * pa;
            x3.pa = x2.pa * pa;
            return x3;
        }
        /// <summary>
        /// Возвращает результат вычитания дробей
        /// </summary>
        /// <param name="x2"></param>
        /// <returns></returns>
        public Fraction Minus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.ma = x2.pa * ma - x2.ma * pa;
            x3.pa = x2.pa * pa;
            return x3;
        }
        /// <summary>
        /// Возвращает результат умножения дробей
        /// </summary>
        /// <param name="x2"></param>
        /// <returns></returns>
        public Fraction Multi(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.ma = x2.ma * ma;
            x3.pa = x2.pa * pa;
            return x3;
        }

        /// <summary>
        /// Возвращает результат деления дробей
        /// </summary>
        /// <param name="x2"></param>
        /// <returns></returns>
        public Fraction Division(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.ma = x2.pa * ma;
            x3.pa = x2.ma * pa;
            return x3;
        }
        /// <summary>
        /// Форматирует значения структуры для вывода
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return ma + "/" + pa + "   =   " + (ma/pa);
        }
        public double Ma
        {
            get { return ma; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) ma = value;
            }
        }
        public double Pa
        {
            get { return pa; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) pa = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int caseWhatWeDo = 0;
            int caseSwitch = 0;
            // Описали объект и создали его.
            Fraction fraction1 = new Fraction(3, 5);
            // Описали объект и создали его.
            Fraction fraction2 = new Fraction(1, 2);
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            // Создали ссылку на объект.
            Fraction result;
            Console.WriteLine("Программа выполняет арифметические операции с дробями.");
            Console.WriteLine(" ");
            Console.WriteLine("Хотите ввести значения дробей или использовать уже заготовленные значения?");
            do
            {
                Console.WriteLine("Введите цифру от 1 до 2. (1-ввести новые.2-заготовленные):       ");
                caseWhatWeDo = Convert.ToInt32(Console.ReadLine());

            } while (caseWhatWeDo != 1 && caseWhatWeDo != 2);


            switch (caseWhatWeDo)
            {
                case 1: 
                    Console.WriteLine("Введите значения дробей (a/b) (c/d).");
                    //Вводим a
                    Console.Write("Введите a:   ");
                    fraction1.Ma = Convert.ToDouble(Console.ReadLine());
                    //Вводим b с проверкой на 0
                    do
                    {
                        Console.Write("Введите b:   ");
                        fraction1.Pa = Convert.ToDouble(Console.ReadLine());
                        if(fraction1.Pa == 0) Console.WriteLine("Знаменатель не может быть равен нулю!");
                    } while (fraction1.Pa == 0);
                    //Вводим c
                    Console.Write("Введите c:   ");
                    fraction2.Ma = Convert.ToDouble(Console.ReadLine());
                    //Вводим d с проверкой на 0
                    do
                    {
                        Console.Write("Введите d:   ");
                        fraction2.Pa = Convert.ToDouble(Console.ReadLine());
                        if (fraction2.Pa == 0) Console.WriteLine("Знаменатель не может быть равен нулю!");
                    } while (fraction2.Pa == 0);
                    break;
                case 2:
                    break;
            }

            Console.WriteLine(" ");
            do
            {
                Console.WriteLine("Введите цифру от 1 до 4. (1-сложение.2-вычитание.3-умножение.4-деление):       ");
                caseSwitch = Convert.ToInt32(Console.ReadLine());

            } while (caseSwitch != 1 && caseSwitch != 2 && caseSwitch != 3 && caseSwitch != 4);


            switch (caseSwitch)
            {
                case 1:
                    result = fraction1.Plus(fraction2);
                    Console.WriteLine($"Сложение дробей ({fraction1.Ma}/{fraction1.Pa}) + ({fraction2.Ma}/{fraction2.Pa})   =  " + result.ToString());
                    break;
                case 2:
                    result = fraction1.Minus(fraction2);
                    Console.WriteLine($"Вычитание дробей ({fraction1.Ma}/{fraction1.Pa}) - ({fraction2.Ma}/{fraction2.Pa})  =  " + result.ToString());
                    break;
                case 3:
                    result = fraction1.Multi(fraction2);
                    Console.WriteLine($"Умножение дробей ({fraction1.Ma}/{fraction1.Pa}) * ({fraction2.Ma}/{fraction2.Pa})  =  " + result.ToString());
                    break;
                case 4:
                    result = fraction1.Division(fraction2);
                    Console.WriteLine($"Деление дробей ({fraction1.Ma}/{fraction1.Pa}) / ({fraction2.Ma}/{fraction2.Pa})  =  " + result.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
