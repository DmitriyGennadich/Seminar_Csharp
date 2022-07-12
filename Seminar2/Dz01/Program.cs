//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите трёхзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            string str = Convert.ToString(number);
            Console.WriteLine($"{str[1]}");
        }

    }
}
