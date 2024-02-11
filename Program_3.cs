// Даны числа x и N. Вычислить сумму x + (x^2 + 2 / x + 1) + (x + x^3 + 3 / x + 2) + (x + x^4 + 4 / x + 3) и так далее, пока результат не превысит заданного числа N.

using System;

class Program
{
    static void Main()
    {
        // Вводим данные
        Console.WriteLine("Введите число x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите предельное число N:");
        double N = double.Parse(Console.ReadLine());
        double sum = 0;
        int z = 1;

        while (true)
        {
            // Вычисляем z-ый член последовательности
            double period = x + Math.Pow(x, z + 1) + z / x + (z - 1);
            // Добавляем член к общей сумме
            sum += period;
            // Проверяем превысила ли сумма N
            if (sum > N)
            {
                // Если да, то останавливаем цикл
                break;
            }
            
            // Если нет, то увеличиваем z для следующего члена последовательности
            z++;
        }

        Console.WriteLine($"Сумма последовательности: {sum}, остановилась на z-ом члене последовательности = {z}");
    }
}