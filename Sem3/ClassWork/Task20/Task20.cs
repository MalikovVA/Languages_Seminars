// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите координату X1: ");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату Y1: ");
        int y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату X2: ");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату Y2: ");
        int y2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"{(double)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))}");
    }
}