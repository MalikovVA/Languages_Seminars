// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

double[,] numbers = new double[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);



int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().NextDouble()*100;
        }
    }
}

void Print2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)  
    {
        for (int j = 0; j < width; j++)  
        {
            Console.Write($"{Math.Round(numbers[i, j],1),4} ");
        }
        Console.WriteLine();
    }
}
