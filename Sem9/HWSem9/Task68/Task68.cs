// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

int firstNum = EnterInt("Enter First Number: ");
int secondNum = EnterInt("Enter Second Number: ");

Console.Write(Akkerman(firstNum, secondNum));

int Akkerman(int i, int j)
{
    if (i == 0)
    {
        return j + 1;
    }
    else if (j == 0 && i > 0)
    {
        return Akkerman(i - 1, 1);
    }
    else
    {
        return (Akkerman(i - 1, Akkerman(i, j - 1)));
    }
}

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}