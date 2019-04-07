using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Иматдинов
//
//Задание 1.
//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
//типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и
// функцией a* sin(x).

namespace Lesson_6
{
    class Program
    {
        /// <summary>
        /// Возвращает результат вычисления функции a* x^2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double F(double a, double x)
        {
            return a * (x * x);
        }

        /// <summary>
        /// Возвращает результат вычисления функции a* sin(x)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Fs(double a, double x)
        {
            return a * Math.Sin(x);
        }

        /// <summary>
        /// Метод сохраняет функцию в бинарный файл
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="a"></param>
        /// <param name="x"></param>
        public static void SaveFunc(string fileName, double a, double x)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(F(a, x));
            bw.Write(Fs(a, x));
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Метод возвращает два значения из бинарного файла в виде массива
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static double[] Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double d = bw.ReadDouble();
            double c = bw.ReadDouble();
            bw.Close();
            fs.Close();
            double[] a = { d, c };
            return a;
        }
        static void Main(string[] args)
        {
            SaveFunc("data.bin", 6, 2);
            double[] a = Load("data.bin");
            foreach (var item in a)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
    }
}
