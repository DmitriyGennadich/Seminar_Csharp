// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace Task52
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

            FillArray(array, a, b);
            PrintArray(array);
            AvarageColumn(array);


        }
        public static void FillArray(int[,] array, int a, int b)
        {
            Random arr = new Random();
            int[,] arr1 = new int[a, b];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(arr.Next(1, 10));
                }
            }
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"[{array[i, j]}] ");
                }
                Console.WriteLine();
            }
        }
        public static void AvarageColumn(int[,] array)
        {
            int count = array.GetLength(0);
            double average = 0;
            double sum = 0;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {  
                    sum = sum +array[j,i];                    
                }
                Console.WriteLine($"Сумма элементов столбца {i+1}: {sum}");
                average = sum / count;
                Console.WriteLine($"Среднее арифметическое столбца {i+1}: {Math.Round(average,2)}");

            }

        }


    }
}