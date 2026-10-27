using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество секунд: ");
        string? input = Console.ReadLine();

        // Защита от некорректного ввода (текст, пустая строка, отрицательные числа)
        if (!int.TryParse(input, out int n) || n < 0)
        {
            Console.WriteLine("Ошибка: введено некорректное или отрицательное число.");
            return;
        }

        int hours = n / 3600;
        int rem = n % 3600;
        int minutes = rem / 60;
        int seconds = rem % 60;

        Console.WriteLine($"Результат: {hours:D2}:{minutes:D2}:{seconds:D2} ({hours} ч. {minutes} мин. {seconds} сек.)");
    }
}
