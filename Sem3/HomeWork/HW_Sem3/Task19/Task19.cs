// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите 5-изначное число: ");
var number = Console.ReadLine()!.ToString();

if (number.Reverse().SequenceEqual(number))
    Console.WriteLine("Ваше число - палиндром");
else
    Console.WriteLine("Ваше число - НЕ палиндром");
