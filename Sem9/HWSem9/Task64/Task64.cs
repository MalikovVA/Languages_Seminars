// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int firstNum = EnterInt("Enter First Number: ");
int secondNum = EnterInt("Enter Second Number: ");


ShowNumsBetween(firstNum, secondNum);


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void ShowNumsBetween(int min, int max)
{
    if (min == max)
    {
        Console.Write(min);
        return;
    }
    if (min > max)
    {
        Console.Write($"{min} ");
        ShowNumsBetween(min - 1, max);
    }
    else
    {
        Console.Write($"{min} ");
        ShowNumsBetween(min + 1, max);

    }
}