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
namespace MyLibTask3
{
    public class MyArray
    {
        int[] a;
        /// <summary>
        /// Массив размера n с рандомными числами от min до max
        /// </summary>
        /// <param name="n"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public MyArray(int n, int min, int step)
        {
            a = new int[n];
            a[0] = min;
            for (int i = 1; i < n; i++)
                a[i] = a[i-1] + step;
        }

        public int[] Inverse()
        {
            int[] inv = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                inv[i] = -a[i];
            return inv;
        }

        public int[] Multi(int n)
        {
            int[] mul = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                mul[i] = a[i] * n;
            return mul;
        }


        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum = a[i] + sum;
                }
                return sum;
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
}
