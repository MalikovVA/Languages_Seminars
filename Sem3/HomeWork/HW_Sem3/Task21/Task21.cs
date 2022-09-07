// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите через ПРОБЕЛ координаты 1-ой точки X1 Y1 Z1:");
string[] part1 = Console.ReadLine()!.Split(' ');
int x1 = int.Parse(part1[0]);
int y1 = int.Parse(part1[1]);
int z1 = int.Parse(part1[2]);
Console.WriteLine("Введите через ПРОБЕЛ координаты 2-ой точки X2 Y2 Z2:");
string[] part2 = Console.ReadLine()!.Split(' ');
int x2 = int.Parse(part2[0]);
int y2 = int.Parse(part2[1]);
int z2 = int.Parse(part2[2]);

Console.WriteLine($"{Math.Round((double)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2)}");



