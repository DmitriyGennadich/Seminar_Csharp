namespace Task1

{
    class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел");
            // Читаем строку из консоли
            string? str = Console.ReadLine();
            // Вызов функции Split -- получение из строки массива по определенному разделителю
            string[] nums = str!.Split(' ');
            //Перебор массива строк с помощью цикла
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

        }
    }
}