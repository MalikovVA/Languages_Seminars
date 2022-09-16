// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int Input(string i)
{
    Console.WriteLine($"Enter {i} number:");
    return int.Parse(Console.ReadLine()!);
}

int a = Input("first");
int b = Input("second");
int c = Input("third");

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("All good");
}
else Console.WriteLine("Not a triangle");

//Console.WriteLine("Enter first number:");
//int a = int.Parse(Console.ReadLine()!);

//Console.WriteLine("Enter second number:");
//int b = int.Parse(Console.ReadLine()!);

//Console.WriteLine("Enter third number:");
//int c = int.Parse(Console.ReadLine()!);