// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


namespace Task43
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите b1: ");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b2: ");
                double b2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите k1: ");
                double k1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите k2: ");
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


/*namespace Task_02
{
    class Program
    {

        static double[,] Coordinates(double k, double b)
        {
            double[,] table = new double[2, 200];
            double count_max = 10;
            double count_min = -10;
            int i = 0;
            int j = 0;

            for (j = 0; j < table.GetLength(1); j++)
            {
                if (count_min <= count_max)
                {
                    table[i, j] = count_min;
                    double x = Math.Round(table[i, j], 2);
                    table[i + 1, j] = (k * x) + b;
                    double y = table[i + 1, j];
                    count_min = count_min + 0.1;

                    //Console.WriteLine($"x = {x} y = {y}"); 
                }

            }
            return table;

        }

        public static void Main()
        {
            Console.WriteLine($" Введите b1 и k1");
            double[,] A = Coordinates(b: Convert.ToDouble(Console.ReadLine()), k: Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine($" Введите b2 и k2");
            double[,] B = Coordinates(b: Convert.ToDouble(Console.ReadLine()), k: Convert.ToDouble(Console.ReadLine()));


            int i = 0;
            int j = 0;

            for (j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] == B[i, j])
                {

                    if (A[i + 1, j] == B[i + 1, j])
                    {
                        Console.WriteLine($"точкa пересечения двух прямых = ({Math.Round(A[i, j], 2)} ; {Math.Round(A[i + 1, j], 2)})");
                    }
                }
            }


        }
    }
}*/