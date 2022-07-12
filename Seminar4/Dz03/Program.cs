// задача 29 Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) 
// элементов (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.

// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
// 6, 1, 33 -> [36, 1, 1089]


namespace Task29
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = new Random().Next(5, 10);
            int[] arr = new int[N];

            FillArray(arr, 1, 41);
            PrintArray1(arr);
            PrintArray(arr);
            Console.WriteLine();

        }

        static void FillArray(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(Math.Pow(array[i], 2) + " ");
                // Console.Write(array[i]*array[i] + " ");
            }
            Console.WriteLine();
        }
        static void PrintArray1(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // Console.Write(Math.Pow(array[i], 2) + " ");
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}