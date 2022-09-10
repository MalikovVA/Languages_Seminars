// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Input first number: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number: ");
int B = int.Parse(Console.ReadLine());

for (int i = 1; i <= B; i++)
    var degree = A * A;



Console.WriteLine($"{degree}");
