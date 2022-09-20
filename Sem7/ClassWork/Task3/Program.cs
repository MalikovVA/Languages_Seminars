// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
ConvertEvenNumbers(numbers, height, width);
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

//static void ConvertEvenNumbers(int[,] numbers, int height, int width)
//{
//    Console.WriteLine();
//    for (int i = 0; i < height; i++)
//    {
//        for (int j = 0; j < width; j++)
//        {
//            if (i % 2 == 0 && j % 2 == 0)
//                numbers[i, j] = numbers[i, j] * numbers[i, j];
//        }

//    }
//}

static void ConvertEvenNumbers(int[,] numbers, int height, int width)
{
    Console.WriteLine();
    for (int i = 0; i < height; i += 2)
    {
        for (int j = 0; j < width; j += 2)
        {
            numbers[i, j] = numbers[i, j] * numbers[i, j];
        }

    }
}