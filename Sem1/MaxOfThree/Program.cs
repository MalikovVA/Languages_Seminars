internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input Number 1 - ");
        //string number1 = Console.ReadLine();
        var num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Number 2 - ");
        var num2 = int.Parse(Console.ReadLine());
        //string number2 = Console.ReadLine();
        Console.WriteLine("Input Number 3 - ");
        //string number3 = Console.ReadLine();

        var num3 = int.Parse(Console.ReadLine());
        int max = num1;
        if (num2 > max)
        {
            max = num2;
        }
        if (num3 > max)
        {
            max = num3;
        }
        Console.WriteLine($"Maximum number of this three is {max}");
    }
}