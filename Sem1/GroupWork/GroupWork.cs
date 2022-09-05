Console.WriteLine("Enter two nums");
string frstnum = Console.ReadLine();
string scndnum = Console.ReadLine();
var num1 = double.Parse(frstnum);
var num2 = double.Parse(scndnum);
if (num1 * num1 == num2)
{
    Console.Write($"{num1} квадратный корень числа {num2}");
}
else if (num2 * num2 == num1)
{
    Console.Write($"{num2} квадратный корень числа {num1}");
}
else
{
    Console.Write("Числа не являются квадратами друг друга");
}
