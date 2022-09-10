// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write("Input first number: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Input second number: ");
int B = int.Parse(Console.ReadLine());
double degree = 1;

degree = Degree(A, B, degree);

static double Degree(int A, int B, double degree)
{
    if (B == 0) Console.WriteLine($"Результатом возведения числа {A} в степень числа {B} является {degree}");
    else if (B < 0) Console.WriteLine("Отрицательная степень числа не допустима");
    else
    {
        for (int i = 1; i < B; i++)
        {
            degree = degree * A;
            Console.Write($"{degree}, ");
        }
        degree = degree * A;
        Console.WriteLine($"{degree}. ");
        Console.WriteLine($"Результатом возведения числа {A} в степень числа {B} является {degree}");
    }

    return degree;
}