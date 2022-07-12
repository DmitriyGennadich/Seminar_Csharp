// // 2. Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]


namespace Task2
{
    class Program
    {
        public static void Main(string[] arg)
        {

            int[] array = new int[8];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 2);
            }
            PrintArray(array, 0);
        }
        public static void PrintArray(int[] nums, int count)
        {
            if (count == 8)
                return;
            Console.Write($"{nums[count]} ");
            PrintArray(nums, count + 1);
        }
    }

}