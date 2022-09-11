// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

// Решение через 8 чисел введенных отельно

Console.WriteLine("Ведите 8 чисел");

int[] array = new int[8];

FillArray(array);
PrintArray(array);

static void PrintArray<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i > 0 && i < array.Length - 1) Console.Write($"{array[i]}, ");
        else if (i == array.Length - 1) Console.Write($"{array[i]}]");
    }
}

static void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

// Решение через строку

//Console.WriteLine("Ведите числа массива через пробел или запятую ");
//string arr = Console.ReadLine();
//string[] array = arr.Split(' ', ',');

//PrintArray(array);