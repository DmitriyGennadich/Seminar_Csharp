// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
namespace Task19
{
    class Program
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Введите пятизначное число: ");
            string? N = Console.ReadLine();


            if (N!.Length == 5)
            {
                PolindromN(N);
            }

            else Console.WriteLine(N + " - Введено число не по заданию");

        }
        static void PolindromN(string N)
        {
            if (N[0] == N[4] && N[1] == N[3])
            {
                Console.Write(N + " - Введенное число полиндром");
            }

            else Console.Write(N + " - Введенное число НЕ полиндром");
        }

    }

}