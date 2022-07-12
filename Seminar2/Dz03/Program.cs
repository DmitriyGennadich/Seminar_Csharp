//  Задача 15  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели: ");
            int number = (Convert.ToInt32(Console.ReadLine())) % 7;

            if (number < 6)
            {
                Console.WriteLine("Будни");
            }
            else
            {
                Console.WriteLine("Выходной");
            }

        }
    }
}