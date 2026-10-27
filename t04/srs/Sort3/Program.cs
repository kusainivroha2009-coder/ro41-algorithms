using System;

class Program
{
    static void Main()
    {
        // Установка кодировки для корректного отображения кириллицы
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Тестирование сортировки трех чисел ===");

        // Проверка требуемых троек
        TestSort(3, 1, 2);
        TestSort(1, 2, 3);
        TestSort(3, 2, 1);
        TestSort(2, 2, 1);
        TestSort(5, 5, 5);
    }

    static void TestSort(int originalA, int originalB, int originalC)
    {
        // Создаем копии переменных для сортировки, сохраняя исходные для вывода
        int a = originalA;
        int b = originalB;
        int c = originalC;

        // Сортируем с помощью метода из класса Order
        Order.Sort3(ref a, ref b, ref c);

        // Вывод результатов в требуемом формате
        Console.WriteLine($"{originalA} {originalB} {originalC} -> {a} {b} {c}");
    }
}

// Статический класс Order по условию задачи
static class Order
{
    // Метод для обмена значениями двух переменных по ссылке
    public static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    // Метод упорядочивания трех чисел по возрастанию, используя только Swap
    public static void Sort3(ref int a, ref int b, ref int c)
    {
        // Сравниваем a и b, если a > b, меняем местами
        if (a > b)
        {
            Swap(ref a, ref b);
        }

        // Сравниваем b и c, если b > c, меняем местами
        if (b > c)
        {
            Swap(ref b, ref c);
        }

        // Повторная проверка первых двух элементов (так как после второго шага мог нарушиться порядок a и b)
        if (a > b)
        {
            Swap(ref a, ref b);
        }
    }
}
