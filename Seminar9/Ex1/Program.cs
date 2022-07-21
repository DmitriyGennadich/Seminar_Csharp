// Задача 1. Из двумерного массива целых чисел удалить строку и столбец,
//  на пересечении которых расположен наименьший элемент.

// Задача 2. Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты
// Например, изначально массив выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = new Random().Next(3, 6);
            int m = new Random().Next(3, 6);
            int[,] array = new int[m, n];

            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            // ChangeSquare(array);
            // PrintArray(array);
            // Console.WriteLine();
            // Console.WriteLine();
            array = Delete(array);
            PrintArray(array);

        }
        public static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void ChangeSquare(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        array[i, j] *= array[i, j];
                    }
                }
            }
        }
        static int[,] Delete(int[,] array)
        {
            int iMin = 0;
            int jMin = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < array[iMin, jMin])
                    {
                        iMin = i;
                        jMin = j;
                    }
                }
            }
            int[,] arr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

            for (int i = 0, k = -1; i < array.GetLength(0); i++)
            {
                if (i != iMin) { k++; }
                else { continue; }

                for (int j = 0, l = -1; j < array.GetLength(1); j++)
                {
                    if (j != jMin) { l++; }
                    else { continue; }
                    arr[k, l] = array[i, j];

                }
            }
            return arr;
        }
    }
}