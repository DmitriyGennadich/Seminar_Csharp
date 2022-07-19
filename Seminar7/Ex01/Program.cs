// using System.Collections.Generic;
// using System.Linq;
// using System;

namespace qwe
{
    class program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            // int[,] b = new int[5, 2] { { 1, 2, 3, 4, 5, }, { 1, 2, 3, 4, 5 } };
            List<int> list = new List<int>();
            // list.Add(6);
            // list.Add(7);
            // list.Add(10);
            FillList(list, 5);

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            List<int> evenNumList = list.FindAll(x => x % 2 == 0);                                      // int num = list.Find(x => x % 2 == 0);
            foreach (int x in evenNumList)
            {
                Console.WriteLine(x);
            }


            // for (int i = 0; i < list.Count; i++)
            // {
            //     list[i] *= 2;
            //     Console.WriteLine(list[i]);
            // }
        }
        public static void FillList(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(new Random().Next(0, 11));
            }
        }
    }
}