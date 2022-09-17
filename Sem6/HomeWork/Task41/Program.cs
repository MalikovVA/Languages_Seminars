// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Решение через последовательный ввод с запросом у пользователя количества элементов.

int[] array = GetArrayLengthFromUser();

CountInputPositiveNumbers(array);

static int[] GetArrayLengthFromUser()
{
    Console.WriteLine("Сколько чисел проверим?");
    int[] array = new int[int.Parse(Console.ReadLine()!)];
    return array;
}

static void CountInputPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Ведите {i + 1} число:");
        array[i] = int.Parse(Console.ReadLine()!);
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Из введенных Вами чисел больше нуля - {count}.");
}

// Решение через свободный ввод

//Console.Write("Введите элементы через пробел: ");
//int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

//GetPositiveNumbers(array);

//static void GetPositiveNumbers(int[] array)
//{
//    int count = 0;

//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] > 0)
//        {
//            count++;
//        }
//    }

//    Console.WriteLine($"Из введенных Вами чисел больше нуля - {count}.");
//}