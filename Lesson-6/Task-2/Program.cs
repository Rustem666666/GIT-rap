using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Иматдинов
//
//Модифицировать программу нахождения минимума функции так, чтобы можно было
//передавать функцию в виде делегата.
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой
//функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов,
//в котором хранятся различные функции.
//б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она
//возвращает минимум через параметр(с использованием модификатора out).
namespace Task_2
{
    delegate double Function(double x);

    class Program
    {
        public static double Fx(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double Fmin(double d)
        {
            double min = double.MaxValue;
            if (d < min) min = d;
            return min;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, Function Fun)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(Fun(x));
                x += h; // x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName, Function Fun)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            
            double d;
            double min = 0;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                min = Fun(d);
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            
            SaveFunc("data.bin", -100, 100, 0.5, Fx);
            Console.WriteLine(Load("data.bin", Fmin));
            Console.ReadKey();
        }
    }
}
