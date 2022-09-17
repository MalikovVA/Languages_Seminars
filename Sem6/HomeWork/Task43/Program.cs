// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1: ");
double k1 = Double.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
double b1 = Double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = Double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = Double.Parse(Console.ReadLine()!);

if (k1 == k2)
{
    Console.WriteLine("Ваши прямые параллельные");
}
else if ((k1 / k2) == (b1 / b2))
{
    Console.WriteLine("Ваши прямые совпадают");
}
else
{
    double x = Math.Round(((b2 - b1) / (k1 - k2)), 3);
    double y = Math.Round((k1 * x + b1), 3);
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}