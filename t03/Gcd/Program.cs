using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("=== Вычисление НОД (Алгоритм Евклида) ===");
        Console.Write("Введите число a: ");
        string inputA = Console.ReadLine();
        
        Console.Write("Введите число b: ");
        string inputB = Console.ReadLine();

        // Проверка корректности ввода (целые числа >= 0, и не оба равны нулю)
        if (!int.TryParse(inputA, out int a) || !int.TryParse(inputB, out int b) || 
            a < 0 || b < 0 || (a == 0 && b == 0))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[Ошибка]: Введены некорректные данные. Требуются целые числа >= 0, при этом a и b не должны быть одновременно равны 0.");
            Console.ResetColor();
            return;
        }

        // Реализация цикла алгоритма Евклида
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        // Вывод результата
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nНаибольший общий делитель (НОД): {a}");
        Console.ResetColor();
    }
}
