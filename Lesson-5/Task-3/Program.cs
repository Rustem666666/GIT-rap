//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task_3
//{
//    class Program
//    {
//        static bool TrueOrNot(string a, string b)
//        {
//            bool c = false;
//            int sum = 0;
//            char[] ArrA = a.ToCharArray();
//            char[] ArrB = b.ToCharArray();
//            int[] ArrC = new int [ArrB.Length];
//            for (int i = 0; i < ArrA.Length; i++)
//            {
//                for (int j = 0; j < ArrB.Length; j++)
//                {
//                    if (ArrA[i] == ArrB[j])
//                    {
//                        if (ArrC[j] == 0) ArrC[j] = 1;
//                    }
//                    else
//                    {
//                        if (ArrC[j] == 0) ArrC[j] = -1;
//                    }
//                }
//            }

//            for (int i = 0; i < ArrB.Length; i++)
//            {
//                Console.WriteLine(ArrC[i]);
//                sum += ArrC[i];
//            }
//            if (sum == ArrC.Length) c = true;

//            return c;
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine(TrueOrNot("badc", "abcd"));
//        }
//    }
//}
