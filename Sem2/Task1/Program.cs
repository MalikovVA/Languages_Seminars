// Print 1&3 digit from number
int number = new Random().Next( 100, 1000 );
Console.WriteLine(number);
//int digit1 = ;
//int digit2 = ;

Console.Write($"{number /100}{number % 10}");
