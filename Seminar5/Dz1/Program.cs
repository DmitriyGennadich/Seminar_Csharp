// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
namespace Task34
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[7];
            RandomArray(numbers, 100, 1000);
            PrintArray(numbers);
            Console.WriteLine();

            int a = QuantityEven(numbers);
            Console.WriteLine($"Количество чётных чисел в массиве: {a}");
        }
            public static void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"[{array[i]}] ");
                }
                Console.WriteLine();
            }
         public static void RandomArray(int[] array, int min, int max)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(min, max);
                }
            }


            public static int QuantityEven(int[] array)
            {
                int quantity = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        quantity++;
                    }
                }
                return quantity;
            }
    }
}