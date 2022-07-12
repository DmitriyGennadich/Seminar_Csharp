
namespace Task2
{
    class Program

    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());     //Читаем число с консолт
            int[] square = GetSquare(a);                    //Получаем результат функции GetSquare

            for (int i = 0; i < square.Length; i++)         // перебор массива с помощью цикла
            {
                Console.WriteLine(square[i] + " ");         // вывод чисел в консоль 
            }
        }


        public static int[] GetSquare(int n)  // Объявление функции
        {
            int[] square = new int[n];       // Создание массива с размерностью n
            for (int i = 1; i <= n; i++)     // Объявление цикла от 1 до n включитеьлно
            {
                square[i - 1] = i * i;       // Запись в i - 1 элемент массива ( по индексу) квадрата числа i
            }
            return square;                   // Возвращение массива
        }
    }
}