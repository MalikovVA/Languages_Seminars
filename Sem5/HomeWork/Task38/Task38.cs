// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Введите размер массива: ");

int[] numbers = CreateRandomArray(int.Parse(Console.ReadLine()!));
PrintArray(numbers);
Console.WriteLine();
int max = FindMax(numbers);
int min = FindMin(numbers);
int substraction = max - min;

Console.WriteLine("В данном масиве самое большое число " + max + ", а самое маленькое " + min + " разница между ними : " + substraction);

int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-100, 100);  // правая граница не включается
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
        System.Console.Write($"{number} ");
}

static int FindMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
    }
    return max;
}

static int FindMin(int[] numbers)
{
    int min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];
    }
    return min;
}

