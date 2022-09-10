// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

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