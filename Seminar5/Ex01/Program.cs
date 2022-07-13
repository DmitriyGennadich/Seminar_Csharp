// 1. Напишите программу замены элементов массива:
// Положительные элементы замените на соответствующие отрицательные и наоборот.
// [-4,-8,8,2]->[4,8,-8,-2]

// 2. Задайте массив. Напишите программу , окторая  отпределяет присутствует ли заданное число в массиве. 5-10 , -20 20

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольное целое число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int a = new Random().Next(5, 11);
            int[] arr = new int[a];
            FillArray(arr);
            PrintArray(arr);
            Console.WriteLine();
            if (Valid(arr, b))
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");

            }

        }
        public static bool Valid(int[] array, int c)
        {
            bool b = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (c == array[i])
                    b = true;
            }
            return b;

        }
        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-20, 21);
            }
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}