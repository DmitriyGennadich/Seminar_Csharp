﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int max = numberA;

            if (numberA > max) max = numberA;
            if (numberB > max) max = numberB;


            Console.Write("max = ");
            Console.WriteLine(max);

        }
    }


}