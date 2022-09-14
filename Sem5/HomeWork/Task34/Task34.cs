// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива: ");

int[] numbers = CreateRandomArray(int.Parse(Console.ReadLine()!));
PrintArray(numbers);
Console.WriteLine();
int count = 0;
count = FindEvenNumbers(numbers, count);
Console.WriteLine("В данном масиве - " + count + " четных чисел");

int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);  // правая граница не включается
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
        System.Console.Write($"{number} ");
}

static int FindEvenNumbers(int[] numbers, int count)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}