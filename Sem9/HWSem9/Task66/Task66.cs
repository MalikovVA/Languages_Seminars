// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int firstNum = EnterInt("Enter First Number: ");
int secondNum = EnterInt("Enter Second Number: ");

if (firstNum == secondNum)
{
    Console.WriteLine("Данные числа равны и между ними нет других натуральных элементов");
}
else
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: = {ShowSumBetween(firstNum, secondNum)}");
}

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

int ShowSumBetween(int firstNum, int secondNum)
{

    if (firstNum == secondNum) return firstNum;
    else if (firstNum < secondNum) return secondNum + ShowSumBetween(firstNum, secondNum - 1);
    else return secondNum + ShowSumBetween(firstNum, secondNum + 1);

}