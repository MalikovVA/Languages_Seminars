// Multiply of 2 numbers
Console.WriteLine("Input first number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number:");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0) {
Console.WriteLine("кратно");
}
else {
    Console.WriteLine($"не кратно, остаток от деления {num1 % num2}");
}
 
