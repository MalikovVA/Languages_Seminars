internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input Number 1 - ");
        //string number1 = Console.ReadLine();
        var num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Number 2 - ");
        //string number2 = Console.ReadLine();
        var num2 = int.Parse(Console.ReadLine());
        int max = num1;
        if (num2 > max)
        {
            max = num2;
        }

        Console.WriteLine($"Max number {max}");
    }
}