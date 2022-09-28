// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

void Zadacha10()
{
    Console.WriteLine("Задача 10");
    Console.WriteLine("Введите трехзначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int tens = number / 10 % 10;
    Console.WriteLine(tens);
}
 Zadacha10();

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Zadacha15()
{
    Console.WriteLine("_____________________________");
    Console.WriteLine("Задача 15");
    Console.WriteLine("Введите цифру от 1 до 7:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (num == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (num == 3)
    {
        Console.WriteLine("Среда");
    }
    if (num == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (num == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (num == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (num == 7)
    {
        Console.WriteLine("Воскресение");
    }

    if (num == 6 || num == 7)
        Console.WriteLine("Выходной день");

}

 Zadacha15 ();

// Задача 13: Напишите программу, которая с помощью деления выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.

void Zadacha13()
{
    Console.WriteLine("_____________________________");
    Console.WriteLine("Задача 13");
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 99)
    {
        Console.WriteLine("Третья цифра в сумме " + number.ToString() + " = " + number.ToString()[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }

}



Zadacha13();