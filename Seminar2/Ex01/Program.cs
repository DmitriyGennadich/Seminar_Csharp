// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(100, 1000);
            Console.WriteLine(number);
            Console.WriteLine($"{number / 100}{number % 10}");

            //Вариант с чтением индекса 
            string str = Convert.ToString(number);
            Console.WriteLine($"{str[0]}{str[2]}");

        }

    }
}
