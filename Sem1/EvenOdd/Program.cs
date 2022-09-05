internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input Your Number - ");
        //string number1 = Console.ReadLine();
        int num1 = int.Parse(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            Console.Write($"Your number {num1} is even");
        }
        else
        {
            Console.Write($"Your number {num1} is odd");
        }
    }
}