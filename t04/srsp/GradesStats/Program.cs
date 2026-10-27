using System;

class Program
{
    // Точка входа в программу (инструкции верхнего уровня)
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        int count = 0;
        int sum = 0;
        int fives = 0;

        int grade = Grades.Read();
        
        while (grade != Grades.Stop)
        {
            if (Grades.IsValid(grade))
            {
                count++;
                sum += grade;
                if (grade == Grades.Max)
                {
                    fives++;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: оценка должна быть от 2 до 5.");
            }
            
            grade = Grades.Read();
        }

        Grades.PrintStats(count, sum, fives);
    }
}

// Статический класс с вспомогательными методами
static class Grades
{
    // Константы вместо «магических чисел»
    public const int Min = 2;
    public const int Max = 5;
    public const int Stop = 0;

    // Метод чтения оценки: нечисловой ввод или некорректные строки возвращают -1
    public static int Read()
    {
        Console.Write("Введите оценку (0 для выхода): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int result))
        {
            return result;
        }

        // Возвращаем -1 для нечислового ввода (чтобы Main распознал его как неверную оценку)
        return -1;
    }

    // Метод проверки корректности оценки (от 2 до 5)
    public static bool IsValid(int g)
    {
        return g >= Min && g <= Max;
    }

    // Метод вывода статистики
    public static void PrintStats(int count, int sum, int fives)
    {
        if (count == 0)
        {
            Console.WriteLine("Оценок нет");
        }
        else
        {
            double average = (double)sum / count;
            Console.WriteLine("\n--- Статистика оценок ---");
            Console.WriteLine($"Всего оценок: {count}");
            Console.WriteLine($"Сумма баллов: {sum}");
            Console.WriteLine($"Количество пятерок: {fives}");
            Console.WriteLine($"Средний балл: {average:F2}");
        }
    }
}
