// задача 64. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 5, 6, 7, 8""

namespace Task64
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число M");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());

            if (PrintNumber(m, n) < 0)
            {
                Console.WriteLine($"N должно быть больше M");
            }
            else
            if (m > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Натуральные числа между M и N:");
                PrintNumber(m, n);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Натуральные числа между M и N:");
                PrintNumber(1, n);
            }
        }


        public static int PrintNumber(int m, int n)
        {
            if (m > 0)
            {
                if (m == n && m != 0)
                {
                    Console.WriteLine(" " + m);
                    return m;
                }
                else
                if (m < n)
                {
                    Console.Write(" " + m);
                    return PrintNumber(m + 1, n);
                }
                else
                {
                    return n - m;
                }
            }
            else
            {
                Console.WriteLine("Натуральные числа это целые больше 0");
                return PrintNumber(1, n);
            }

        }
    }

}
