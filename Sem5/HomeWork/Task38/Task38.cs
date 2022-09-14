// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Введите размер массива: ");

int[] numbers = CreateRandomArray(int.Parse(Console.ReadLine()!));
PrintArray(numbers);
Console.WriteLine();
int max = FindMax(numbers, numbers[0]);
int min = FindMin(numbers, numbers[0]);
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

static int FindMax(int[] numbers, int Max)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > Max)
            Max = numbers[i];
    }
    return Max;
}

static int FindMin(int[] numbers, int Min)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < Min)
            Min = numbers[i];
    }
    return Min;
}

