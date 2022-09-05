// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int[] array = new int[number.Length];

for( int i=0; i< number.Length; i++)
{
     array[i] = int.Parse(number[i].ToString());
}

if (number.Length < 3)
{
    Console.WriteLine("No 3rd digit");
}
else
    Console.WriteLine(array[2]);
 