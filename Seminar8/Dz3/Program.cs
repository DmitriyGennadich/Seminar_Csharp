// Задайте две матрицы. Напишите программу, которая выведет матрицу
// произведения элементов двух предыдущих матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
namespace Task58
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов");
            int b = Convert.ToInt32(Console.ReadLine());


            int[,] array = new int[a, b];
            int[,] array2 = new int[a, b];

            FillArray(array, a, b);
            Console.WriteLine("Первый массив ");
            PrintArray(array);
            FillArray(array2, a, b);
            Console.WriteLine("Второй массив ");
            PrintArray(array2);
            Console.WriteLine("РЕзультат перемножения массивов");
            PrintArray(ResultArray(array, array2));

        }
        public static void FillArray(int[,] arr, int m, int n)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(0, 10);
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
        public static int[,] ResultArray(int[,] array, int[,] array2)
        {
            int[,] result = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[i, j] = array[i, j] * array2[i, j];
                }
            }
            return result;
        }
    }
}