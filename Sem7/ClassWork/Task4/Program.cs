//// Задайте двумерный массив. Найдите сумму
//элементов, находящихся на главной диагонали (с индексами
//(0,0); (1; 1) и т.д.


int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);



int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}


void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)  // для каждой строки
    {
        for (int j = 0; j < width; j++)  // внутри этой строки для каждого столбца
        {
            Console.Write($"{numbers[i, j],3} ");

        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine(SumNumbersOnMainDiagonal(height, width, numbers));

static int SumNumbersOnMainDiagonal(int height, int width, int[,] numbers)
{
    int sum = 0;
    for (int i = 0; i < height; i++)  // для каждой строки
    {
        for (int j = 0; j < width; j++)  // внутри этой строки для каждого столбца
        {
            if (i == j)
                sum += numbers[i, j];
        }
    }
    return sum;
}
