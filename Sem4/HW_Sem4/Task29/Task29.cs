// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

// Решение через 8 чисел введенных отельно
Console.WriteLine("Ведите 8 чисел");

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine()!);
}
for (int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write($"[{array[i]}, ");
    if (i > 0 && i < array.Length - 1) Console.Write($"{array[i]}, ");
    if (i == array.Length - 1) Console.Write($"{array[i]}]");
}

// Решение через строку

Console.WriteLine("Ведите числа массива через пробел или запятую ");
string arr = Console.ReadLine();
string[] array = arr.Split(' ', ',');

for (int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write($"[{array[i]}, ");
    if (i > 0 && i < array.Length - 1) Console.Write($"{array[i]}, ");
    if (i == array.Length - 1) Console.Write($"{array[i]}]");
}