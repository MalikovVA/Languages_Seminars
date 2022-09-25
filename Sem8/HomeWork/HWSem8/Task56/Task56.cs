// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);

int[] arrayOfSumInRowsFrom2DArray = SumInRowsIn2DArray(numbers);

int minSumRow = FindIndexOfMin(arrayOfSumInRowsFrom2DArray);
Console.WriteLine($"Наименьшая сумму элементов находится в {minSumRow+1} строке");


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

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

int[] SumInRowsIn2DArray(int[,] array)
{
    int[] SumArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        SumArray[i] = sum;
    }

    return SumArray;
}


int FindIndexOfMin(int[] array)
{
    int indexOfMin = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            indexOfMin = i;
        }
    }
    return indexOfMin;

}

