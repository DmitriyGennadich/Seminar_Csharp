// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

namespace Task27
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите число N: ");
            int numberN = Convert.ToInt32(Console.ReadLine());
            int sumNumber = SumNumber(numberN);
            Console.WriteLine("Сумма цифр в числе: " + sumNumber);
        }
        public static int SumNumber(int numberN)
        {

            int counter = Convert.ToString(numberN).Length; // Перевели число в символьный формат
            int nums = 0;
            int result = 0;

            for (int i = 0; i < counter; i++)
            {
                nums = numberN - numberN % 10;              // Получаем 
                result = result + (numberN - nums);         // сумму
                numberN = numberN / 10;                     // цифр
            }
            return result;
        }
    }
}




