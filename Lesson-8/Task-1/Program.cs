using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//Иматдинов
//
//Задача 1.
//С помощью рефлексии выведите все свойства структуры DateTime

namespace Task_1
{
    class Program
    {

        static PropertyInfo[] GetPropertyInfo(object obj)
        {
            return obj.GetType().GetProperties();
        }
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            //dateTime.DayOfWeek
            PropertyInfo[] props = GetPropertyInfo(dateTime);
            foreach (var prop in props)
                if (prop.GetIndexParameters().Length == 0)
                    Console.WriteLine("   {0} ({1}): {2}", prop.Name, prop.PropertyType.Name, prop.GetValue(dateTime));
            Console.ReadKey();
        }
    }
}
