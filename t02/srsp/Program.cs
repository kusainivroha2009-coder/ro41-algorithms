using System;

class Program
{
    static void Main()
    {
        // Установка кодировки для корректного отображения кириллицы
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.Write("Введите целое неотрицательное число n: ");
        string input = Console.ReadLine();

        // Проверка корректности ввода (целое число >= 0)
        if (!int.TryParse(input, out int n) || n < 0)
        {
            Console.WriteLine("Ошибка: введено некорректное значение.");
            return;
        }

        int temp = n;
        int sum = 0;
        int count = 0;

        // Цикл с постусловием (гарантированно отрабатывает хотя бы 1 раз, что важно для числа 0)
        do
        {
            int digit = temp % 10;
            sum += digit;
            count++;
            temp /= 10;
        } 
        while (temp > 0);

        // Вывод результатов
        Console.WriteLine($"Количество цифр: {count}");
        Console.WriteLine($"Сумма цифр: {sum}");
    }
}
