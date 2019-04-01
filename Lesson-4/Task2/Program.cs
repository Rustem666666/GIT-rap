using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Иматдинов

//Задача 2:
//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает
//задачу 1;
//б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен
// возвращать массив целых чисел;
//в)** Добавьте обработку ситуации отсутствия файла на диске.
namespace Task2
{
    public static class MyArray
    {
        /// <summary>
        /// Возвращает количество пар кратное 3
        /// </summary>
        /// <param name="n"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Par3Mass(int n, int min, int max)
        {
            int par = 0;
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
            int x, y;
            for (int i = 0; i < a.Length; i++)
            {
                x = a[i];
                if (i + 1 > a.Length - 1)
                {
                    y = 0;
                }
                else
                {
                    y = a[i + 1];
                }
                //Присваиваем единицу, если значение равно 0, иначе условие работает не правильно
                if (x == 0) x = 1;
                if (y == 0) y = 1;
                if ((x % 3 == 0 && y % 3 != 0) || (x % 3 != 0 && y % 3 == 0)) par += 1;
                i += 1;
            }
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            Console.WriteLine("Массив: \n" + s);
            return par;
        }

        public static int[] ReadFromFileMass(string filename)
        {
            int[] mass = new int[1];
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    // Считываем количество элементов массива
                    int N = int.Parse(sr.ReadLine());
                    mass = new int[N];
                    // Считываем массив
                    for (int i = 0; i < N; i++)
                    {
                        mass[i] = int.Parse(sr.ReadLine());
                    }
                    //while (!sr.EndOfStream)
                    //{
                    //    Console.WriteLine(sr.ReadLine());
                    //}
                }
            }
            else
            {
                Console.WriteLine("Файл не существует.");
            }
            string s = "";
            foreach (int v in mass)
                s = s + v + " ";
            Console.WriteLine("Массив: \n" + s);
            return mass;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int F = MyArray.Par3Mass(10, -10000, 10000);
            Console.WriteLine(F);

            int[] A = MyArray.ReadFromFileMass("data.txt");
        }
    }
}
