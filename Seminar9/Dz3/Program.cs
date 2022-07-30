// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
namespace Task68
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число M");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            if (m < 5 && m>=0)
            {
                int functionAkkerman = FunctionAkkermana(m, n);
                Console.Write($"Функция Аккермана = {functionAkkerman} ");
            }
            else { Console.WriteLine("Введите M от 0 до 4");}
        }
        public static int FunctionAkkermana(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else
            if (n == 0)
                return FunctionAkkermana(m - 1, 1);
            else
                return FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1));
        }

    }
}