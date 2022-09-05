// Multiple both to 7&23 

Console.WriteLine("Input number:");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0) 
    Console.WriteLine($"{num} - кратно и 7 и 23");
else
    Console.WriteLine($"{num} - НЕ кратно и 7 и 23");
