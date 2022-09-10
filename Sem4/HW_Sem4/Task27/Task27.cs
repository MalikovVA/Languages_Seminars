// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Input a number: ");
int num = int.Parse(Console.ReadLine());

int sum = 0;
int n = num;
while(n > 0)
{
    sum = sum + n % 10;
    n = n / 10;
}
Console.WriteLine($"Сумма цифр в числе {num} - {sum}");