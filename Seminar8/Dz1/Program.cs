// 54. Задайте двумерный массив. Напишите программу, которая упорядочит
// по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

namespace Task54
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[a, b];
            Console.WriteLine("Пустой массив:");
            PrintArray(array);
            Console.WriteLine();
            FillArray(array, a, b);
            PrintArray(array);
            Console.WriteLine("Отсортированные строки массива: ");
            SortArray(array);
            PrintArray(array);
        }
        public static void FillArray(int[,] arr, int a, int b)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(0, 20);
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

        public static void SortArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                        if (array[i, k] > array[i, k + 1])
                        {
                            int max = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = max;
                        }
                }
            }
        }
    }
}
