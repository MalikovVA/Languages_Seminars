// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.



int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);

int i = EnterInt("Введите номер строки: ")-1; 
// Вычитаю едиицу, чтобы пользователь мог ввсети номера строк и столбов в общепрнятом понимании (не программистском)
// нумерация строк и столбцов с 1 
int j = EnterInt("Введите номер столбца: ")-1;

if (i < numbers.GetLength(0) && j < numbers.GetLength(1))
{
    Console.WriteLine($"На позиции [{i+1},{j+1}] находится элемент {numbers[i, j]}.");
}
else Console.WriteLine($"Такого элемента [{i+1},{j+1}] в массиве не существует.");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)  
    {
        for (int j = 0; j < width; j++)  
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}
