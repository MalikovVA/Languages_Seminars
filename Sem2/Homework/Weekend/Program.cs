// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число:");
int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("It's a weekend!!!");
}
else if (day <1 || day > 7)
{
    Console.WriteLine("It's not a day of the week");
}
else
{
    Console.WriteLine("It's pity, but time to go for a work(((");
    }