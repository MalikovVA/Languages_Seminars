// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Первый массив:");
int[,] matrix1 = new int[2, 2];

Fill2DArray(matrix1);
Print2DArray(matrix1);

Console.WriteLine("Второй  массив:");
int[,] matrix2 = new int[2, 2];

Fill2DArray(matrix2);
Print2DArray(matrix2);

Console.WriteLine("Произведение двух матриц:");
Print2DArray(MultiplyArray(matrix1, matrix2));

void Fill2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j],2} ");
        }
        Console.WriteLine();
    }
}

static int[,] MultiplyArray(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}