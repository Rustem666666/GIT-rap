using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Иматдинов
//
//Задача 2.
//Разработать статический класс Message, содержащий следующие статические методы для
//обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в
//него передается массив слов и текст, в качестве результата метод возвращает сколько раз
//каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.

namespace Task_2
{
    static class Message
    {
        public static string MessageNFilter(string text, int n)
        {
            StringBuilder a = new StringBuilder();
            char[] div = { ' ' };
            string[] parts = text.Split(div);
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length <= n) a.Append(parts[i] + " ");
            }
            
                return Convert.ToString(a);
        }

        public static string MessageSDelete(string text, string n)
        {
            StringBuilder a = new StringBuilder();
            char[] div = { ' ' };
            string[] parts = text.Split(div);
            for (int i = 0; i < parts.Length; i++)
            {
                if (!parts[i].EndsWith(n)) a.Append(parts[i] + " ");
            }

            return Convert.ToString(a);
        }

        public static string MessageMax(string text)
        {
            char[] div = { ' ' };
            string[] parts = text.Split(div);
            string max = parts[0];
            for (int i = 1; i < parts.Length; i++)
            {
                if (parts[i].Length > max.Length) max = parts[i];
            }

            return max;
        }

        public static string MessageBuilderMax(string text)
        {
            StringBuilder a = new StringBuilder();
            char[] div = { ' ' };
            string[] parts = text.Split(div);
            string max = parts[0];
            for (int i = 1; i < parts.Length; i++)
            {
                if (parts[i].Length > max.Length) max = parts[i];
            }
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length == max.Length) a.Append(parts[i] + " ");
            }
            return Convert.ToString(a);
        }
    }

    class Program
    {
        static void Main()
        {
            //Вывести только те слова сообщения, которые содержат не более n букв
            Console.WriteLine(Message.MessageNFilter("Вывести только те слова сообщения, которые содержат не более n букв", 5));

            //Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            Console.WriteLine(Message.MessageSDelete("Удалить из сообщения все слова, которые заканчиваются на заданный символ", "я"));

            //в) Найти самое длинное слово сообщения.
            Console.WriteLine(Message.MessageMax("Найти самое длинное слово сообщения"));

            //Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            Console.WriteLine(Message.MessageBuilderMax("Сформировать строку с помощью StringBuilder из самых длинных слов сообщения"));

        }
    }
}
