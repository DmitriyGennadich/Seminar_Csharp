// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

namespace Task47
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Количество строк m : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество столбцов n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] array = new double[m, n];

            FillArray(array, m, n);
            PrintArray(array);
        }
        public static void FillArray(double[,] arr, int m, int n)
        {
            Random array1 = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToDouble(array1.Next(-100, 100) / 10.0);

                }
            }
        }
        public static void PrintArray(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{arr[i, j]}]  ");
                }
                Console.WriteLine();
            }

        }
    }
}