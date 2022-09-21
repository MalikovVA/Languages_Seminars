// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.



int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
PrintColumnAvrSum(numbers, height, width);


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
            numbers[i, j] = new Random().Next(-10, 10);
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void PrintColumnAvrSum(int[,] numbers, int height, int width)
{

    for (int j = 0; j < width; j++)
    {
        float avrsum = 0;
        for (int i = 0; i < height; i++)
        {
            avrsum += numbers[i, j];
        }
        Console.Write($"{Math.Round(avrsum / height,1)};  ");
    }
}