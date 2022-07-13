// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


namespace Task38
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] arrayRealNumbers = new double[10];
            for (int i = 0; i < arrayRealNumbers.Length; i++)
            {
                arrayRealNumbers[i] = new Random().Next(1, 100);
                Console.Write(arrayRealNumbers[i] + " ");
            }

            double maxNumber = arrayRealNumbers[0];
            double minNumber = arrayRealNumbers[0];

            for (int i = 1; i < arrayRealNumbers.Length; i++)
            {
                if (maxNumber < arrayRealNumbers[i])
                {
                    maxNumber = arrayRealNumbers[i];
                }
                if (minNumber > arrayRealNumbers[i])
                {
                    minNumber = arrayRealNumbers[i];
                }
            }

            double diff = maxNumber - minNumber;
            Console.WriteLine();
            Console.WriteLine($"разница между между max = {maxNumber} и min = {minNumber} элементами: {diff}");

        }
    }
}