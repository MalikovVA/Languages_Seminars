// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

HashSet<int> numbers = new HashSet<int>();
Random r = new Random();

int[,,] array = new int[2, 2, 2];

Fill3DArray(array);
Print3DArray(array);

int GenerateUniqueNumber()
{
    while (true)
    {
        var n = r.Next(10, 100);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}

void Fill3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                //array3D[i, j, k] = new Random().Next(10,100);
                array3D[i, j, k] = GenerateUniqueNumber();
            }
        }
    }
}

void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                //Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                Console.Write($"{k+1}-ый слой {array[i, j, k]}({i},{j})  ");
            }
            Console.WriteLine();
        }
    }
}