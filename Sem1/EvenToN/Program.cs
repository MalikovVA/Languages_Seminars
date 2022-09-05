internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please, Input A Number - ");
        //string number1 = Console.ReadLine();
        var num1 = int.Parse(Console.ReadLine());


        for (int i = 2; i <= num1; i += 2)
            //if (i % 2 == 0)
            //{
                Console.Write($"{i}, ");
            //}
    }
}
//else
//{
//Console.Write($"Your number {num1} is odd");
//}
