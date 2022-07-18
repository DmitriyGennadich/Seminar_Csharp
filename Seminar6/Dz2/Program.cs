// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


namespace Task43
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите b1");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b2");
                double b2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите k1: ");
                double k1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите k2");
                double k2 = Convert.ToDouble(Console.ReadLine());

                if (k1 != k2)
                {
                    double x = (b2 - b1) / (k1 - k2);
                    double y = k1 * x + b1;
                    Console.WriteLine($"Точка пересечения прямых   х: {x}, y:{y}");
                }
                else
                    Console.WriteLine("Прямые параллельны");
            }
            catch
            {
                Console.WriteLine("Введены неверные данные");
            }

        }

    }
}

/* namespace Task43
{
    class Program
    {
        public static void Main(string[] args)
        {
            
        }
        public static void Input (double [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)

            {
                Console.Write($"Введите коэффициенты {i+1} уровнения (y = k * x + b):");  
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(j==0) Console.Write($"Введите коэффициент k: ");
                    else Console.Write($"Введите коэффициент b: ");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

        }
    }
}*/