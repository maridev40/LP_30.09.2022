// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, 
// остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 99)
{
    Console.Write("третьей цифры нет");
}
else
{
    while (a > 999)
    {
        a = a / 10;
    }

    a = a % 10;
    Console.Write($"третья цифра: {a}");
}
