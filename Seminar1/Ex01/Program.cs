namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            // 1. Получаем число
            int number = Convert.ToInt32(Console.ReadLine());
            // 2. Умножаем и записываем в отдельную переменную
            int square = number * number;
            // или 2. Получаем квадрат в переменной number
            number *= number;

            // Вывод результата
            Console.WriteLine($"Квадрат числа: {square}");
        }
    }
}
