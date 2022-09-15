// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


Console.WriteLine("Введите размер массива: ");

int[] numbers = CreateRandomArray(int.Parse(Console.ReadLine()!));
PrintArray(numbers);
Console.WriteLine();
int indexSum = FindOddIndexSum(numbers, 0);
Console.WriteLine("В данном масиве сумма чисел, находящихся на нечетных местах равна " + indexSum);

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

static int FindOddIndexSum(int[] numbers, int sum)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sum += numbers[i];
    }
    return sum;
}