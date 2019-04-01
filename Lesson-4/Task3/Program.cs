using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibTask3;


//Иматдинов

//Задача 3:
//а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
//массив определенного размера и заполняющий массив числами от начального значения с
//заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод
//Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый
//массив, остается без изменений), метод Multi, умножающий каждый элемент массива на
//определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
//б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу
//библиотеки
//е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
namespace Task3
{
    class Program
    {
        public static string ToS(int[] f)
        {
            string s = "";
            foreach (int v in f)
                s = s + v + " ";
            return s;
        }

        static void Main(string[] args)
        {
            MyArray a = new MyArray(20, 1, 1);
            Console.WriteLine("\nМассив: \n" + a.ToString());
            Console.WriteLine("\nСумма элементов массива: \n" + a.Sum);
            int[] F = a.Inverse();
            Console.WriteLine("\nИнвертированный массив: \n" + ToS(F));
            int[] S = a.Multi(3);
            Console.WriteLine("\nМассив перемноженный на 3: \n" + ToS(S));
            //свойство MaxCount, возвращающее количество максимальных элементов?
        }
    }
}
