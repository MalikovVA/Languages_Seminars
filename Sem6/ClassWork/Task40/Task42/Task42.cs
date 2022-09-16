// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45-> 101101
//3-> 11
//2-> 10

Console.WriteLine("Input your number:");

int input = int.Parse(Console.ReadLine()!);// get number 23
// Для перевода в двоичную систему необходимо разделить на 2 и посмотреть на остаток от деления на 2
string array = string.Empty;

while (input > 0)
{
    int digit = input % 2;
    input = input / 2;
    array = digit + array;
}

Console.WriteLine(array);