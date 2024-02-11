// Вычислить процент материала, ушедшего в отход, если из цилиндра диаметром D и высотой L была сделана правильная призма максимальных размеров, в основании, которой лежит равносторонний треугольник.

using System;
class Program
{
    static void Main()
    {
        // Ввод диаметра D и высоты L
        Console.WriteLine("Введите диаметр D цилиндра: ");
        double D = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите высоту L цилиндра: ");
        double L = double.Parse(Console.ReadLine());

        // Вычисление объема цилиндра
        double V_cylinder = Math.PI * Math.Pow(D / 2, 2) * L;

        // Сторона равностороннего треугольника равна диаметру цилиндра
        double a = D;

        // Вычисление объема призмы
        double V_prism = (Math.Sqrt(3) / 4) * Math.Pow(a, 2) * L;

        // Вычисление процента отходов
        double PercentOthodov = (1 - (V_prism / V_cylinder)) * 100;

        Console.WriteLine($"Процент материала, ушедшего в отход: {PercentOthodov}%");
    }
}