// Даны числа A, B, C. Меньшее из них надо утроить, "среднее" по величине надо удвоить. После этого вновь найти большее, "среднее" и меньшее.
class Program
{
    static void Main()
    {
        // Вводим числа A, B, C
        Console.WriteLine("Введите число A:");
        double A = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число B:");
        double B = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число C:");
        double C = double.Parse(Console.ReadLine());
        double max = 0, min = 0, mid = 0;

        // Находим максимальное число
        if (A > B && A > C) max = A;
        else if (B > A && B > C) max = B;
        else max = C;

        // Находим минимальное число
        if (A < B && A < C) min = A;
        else if (B < A && B < C) min = B;
        else min = C;

        // Находим среднее число
        mid = A + B + C - max - min;

        // Минимальное число утраиваем, а среднее удваиваем
        if (A == min) A *= 3;
        else if (A == mid) A *= 2;
        if (B == min) B *= 3;
        else if (B == mid) B *= 2;
        if (C == min) C *= 3;
        else if (C == mid) C *= 2;

        // Выводим измененные значения
        Console.WriteLine($"Новое значение A: {A}");
        Console.WriteLine($"Новое значение B: {B}");
        Console.WriteLine($"Новое значение C: {C}");
    }
}
