// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)

// 5 -> 2, 4
// 8 -> 2, 4, 6

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до N: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int n = 1; n < number; n++)
            {
                if (n % 2 == 0)
                {

                    Console.Write(n + " ");
                }

            }
            Console.Write("- Четные числа интервала от 1 до " + number);

        }
    }


}
