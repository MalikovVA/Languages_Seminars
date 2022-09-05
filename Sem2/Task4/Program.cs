// Square one of another

Console.WriteLine("Input first number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number:");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2*num2 || num2 == num1*num1)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

