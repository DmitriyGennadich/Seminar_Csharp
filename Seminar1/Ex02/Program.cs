namespace Task2
{
    class Program
    {
        // Напишите программу, которая будет выдавать название дня недели по заданному номеру.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели: ");
            int number = (Convert.ToInt32(Console.ReadLine())) % 8;
            string day = "";
            if (number == 1) day = "Понедельник";
            if (number == 2) day = "Вторник";
            if (number == 3) day = "Среда";
            if (number == 4) day = "Четверг";
            if (number == 5) day = "Пятница";
            if (number == 6) day = "Суббота";
            if (number == 7) day = "Воскресенье";
            Console.WriteLine($"Номер дня соответствует: {day}");

        }

    }
}
