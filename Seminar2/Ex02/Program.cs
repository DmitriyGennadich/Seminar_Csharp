// // Напишите программу, которая будет принимать на вход два числа и 
// выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток 
// от деления.

// // 34, 5 -> не кратно, остаток 4
// // 16, 4  -> кратно


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            if (number1 % number2 == 0)
            {
                Console.WriteLine("Кратно");
            }
            else
            {
                Console.WriteLine($"Не кратно, остаток {number1 % number2}");
            }

        }

    }
}
