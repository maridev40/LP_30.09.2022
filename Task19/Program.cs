// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
int num = number;
int count = 0;

while (num > 0)
{
    a[count] = num % 10;
    num = num / 10;
    count++;
}

bool palindrom = true;

for (int i = 0; i < count - 1; ++i)
{
    if (a[i] != a[count - i - 1])
        palindrom = false;
}

if (palindrom == true)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
