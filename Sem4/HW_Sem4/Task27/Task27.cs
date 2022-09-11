// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Input a number: ");

SumOfDigits();

static void SumOfDigits()
{
    int num = int.Parse(Console.ReadLine());
    int sum = 0;
    int temp = num;
    while (temp > 0)
    {
        sum += temp % 10;
        temp = temp / 10;
    }
    Console.WriteLine($"Сумма цифр в числе {num} - {sum}");
}