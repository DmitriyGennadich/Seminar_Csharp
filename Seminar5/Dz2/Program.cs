﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


namespace Task36
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write($"Введи количество элементов массива: ");
            int numberElements = Convert.ToInt32(Console.ReadLine());


            int randomNumbers = RandomNumbers(numberElements, 1, 10);

            Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");

        }
        public static int RandomNumbers(int numberElements, int min, int max)
        {
            int[] randomNumbers = new int[numberElements];
            int sumElements = 0;
            Console.Write("Получившийся массив: ");

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = new Random().Next(min, max);

                Console.Write(randomNumbers[i] + " ");

                if (i % 2 != 1)
                {
                    sumElements = sumElements + randomNumbers[i];
                }
            }
            return sumElements;
        }

    }
}