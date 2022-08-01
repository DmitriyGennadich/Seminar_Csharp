// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

namespace Task50
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int m = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"В массиве строк: {m}");
            Console.WriteLine("Введите количество столбцов:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В массиве столбцов: {n} строк: {m}");

            int[,] array = new int[m, n];


            FillArray(array, m, n);
            PrintArray(array);

            Console.WriteLine("Введите индекс строки");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите индекс столбца");
            int l = Convert.ToInt32(Console.ReadLine());

            FindNumber(array, k, l);

        }
        
        public static void FillArray(int[,] arr, int m, int n)
        {
            Random arr1 = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToInt32(arr1.Next(-100, 100) / 10.0);

                }
            }
        }
        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{arr[i, j]}] ");
                }
                Console.WriteLine();
            }

        }
        public static void FindNumber(int[,] arr, int k, int l)
        {
            try
            {
                if (k >= arr.GetLength(0) || l >= arr.GetLength(1))
                {
                    Console.WriteLine("Такого элемента в массиве нет");
                }
                else { Console.WriteLine($"Искомый элемент на заданной позиции:{arr[k, l]} "); }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Такого элемента в массиве нет");
            }
        }
    }

}
