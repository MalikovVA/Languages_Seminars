// See https://aka.ms/new-console-template for more information

// 63
void GetNaturnalRow(int n)
{
    if (n == 1)
        return "1";

    return GetNaturnalRow(n - 1) + ", " + n;
}

//65.1
void ShowAllNums(int num)
    {
        if (num < 1)
        {
            Console.WriteLine();
            return;
        }
        Console.Write($"{num} ");
        ShowAllNums(num - 1);
        Console.Write($"{num} ");


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
            Console.Write($"{max} ");
            ShowNumsBetween(min, max - 1);

        }
    }

    ShowNumsBetween(6, 1);
//65.2

/// <summary>Находит минимальное число из двух (int)</summary>
int Min(int a, int b)
{
    return a < b ? a : b;
}

/// <summary>Находит максимальное число из двух (int)</summary>
int Max(int a, int b)
{
    return a > b ? a : b;
}

string GetNaturnalRow(int rangeMin, int rangeMax)
{
    if (rangeMax == rangeMin)
        return rangeMax.ToString();

    return rangeMax + ", " + GetNaturnalRow(rangeMin, rangeMax - 1);
}

// 67
int GetNumbersSum(int number)
{
    if (number == 0)
        return 0;
    return GetNumbersSum(number / 10) + number % 10;
}

// 69
int Pow(int @base, int degree)
{
    if (degree == 0)
        return 1;

    return Pow(@base, degree - 1) * @base;
}
