using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Иматдинов

//Задача 1:
//Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
//значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
//программу, позволяющую найти и вывести количество пар элементов массива, в которых только
//одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
//элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
namespace Lesson_4
{
    class MyArray
    {
        int[] a;

        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }

        public int Par3
        {
            get
            {
                int par = 0;
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
                return par;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(20, -10000, 10000);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Par3);
        }
    }

}
