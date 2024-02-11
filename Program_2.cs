// Даны числа A, B, C. Меньшее из них надо утроить, "среднее" по величине надо удвоить. После этого вновь найти большее, "среднее" и меньшее.

using System;

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

        // Находим минимальное, большое и среднее число
        double min = Math.Min(A, Math.Min(B, C));
        double max = Math.Max(A, Math.Max(B, C));
        double mid = A + B + C - min - max;

        // Минималку X3
        if (A == min) A *= 3;
        else if (B == min) B *= 3;
        else if (C == min) C *= 3;
        
        // Среднее X2
        if (A == mid) A *= 2;
        else if (B == mid) B *= 2;
        else if (C == mid) C *= 2;

        // Вывод измененных значений
        Console.WriteLine($"Новое значение A: {A}");
        Console.WriteLine($"Новое значение B: {B}");
        Console.WriteLine($"Новое значение C: {C}");
    }
}