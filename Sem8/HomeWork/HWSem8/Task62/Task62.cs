// Заполните спирально массив 4 на 4.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] array = new int[height, width];
PrintSpiralArray(array);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

static void PrintSpiralArray(int[,] array)
{
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = array.GetLength(1);
    for (int i = 0; i < array.Length; i++)
    {
        array[row, col] = i + 1;
        if (--gran == 0)
        {
            gran = array.GetLength(1) * (dirChanges % 2) + array.GetLength(0) * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
}