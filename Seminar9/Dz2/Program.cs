// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


namespace Task66
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число M");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (SumNumber(m, n, sum) < 0)
            {
                Console.WriteLine($"N должно быть больше M");
            }
            else
            if (m > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Сумма натуральных чисел:{SumNumber(m, n, sum)}");
            }
            else
            {
                Console.WriteLine($"Сумма натуральных чисел:{SumNumber(1, n, sum)}");
                
            }
        }
        public static int SumNumber(int m, int n, int sum)
        {
            if (m > 0)
            {
                if (m == n && m != 0)
                {
                    return sum + n;
                }
                else
                if (m < n)
                {
                    sum = sum + m;
                    return SumNumber(m + 1, n, sum);
                }
                else
                {
                    return n - m;
                }
            }
            else
            {
                Console.WriteLine("Натуральные числа это целые больше 0");
                return SumNumber(1, n, sum);
            }
        }
    }
}