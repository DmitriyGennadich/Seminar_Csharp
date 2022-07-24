        // Задайте прямоугольный двумерный массив. Напишите программу, 
        //которая будет находить строку с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и выдаёт 
        //номер строки с наименьшей суммой элементов: 1 строка
namespace Task56
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите количество строк");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В массиве строк: {m}");
            Console.WriteLine("Введите количество столбцов");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В массиве столбцов: {n}");

            int[,] array = new int[m, n];

            Console.WriteLine("Пустой массив:");
            PrintArray(array);
            Console.WriteLine();
            FillArray(array, m, n);
            Console.WriteLine("Заданный массив");
            PrintArray(array);
            Summelements(array);

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
        public static void Summelements(int[,] array)
        {
            int min = 0; int str = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int summ = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    summ = summ + array[i, j];
                }
                if (i > 0 && summ < min)
                {
                    min = summ;
                    str = i;
                }
                if (i == 0)
                {
                    min = summ;
                    str = i;
                }
            }
            Console.WriteLine($"Минимальная сумма элементов = {min} в строке {str + 1} ");
        }
    }
}