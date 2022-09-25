// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);

Console.WriteLine("Сортировка по строкам: ");
SortArray(numbers);
Print2DArray(numbers);

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


void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        bool needSort = true;
        while (needSort)
        {
            needSort = false;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                int item1 = array[i, j];
                int item2 = array[i, j + 1];
                if (item1 < item2)
                {
                    array[i, j] = item2;
                    array[i, j + 1] = item1;
                    needSort = true;
                }
            }
        }
    }
}