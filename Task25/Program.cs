// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 < 1)
{
    Console.WriteLine($"Число B не является натуральным");
    return;
}

int product = Product(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} равно {product}");

int Product(int a, int b)
{
    int res = a;
    try
    {
        for (int i = 1; i < b; i++)
        {
            checked
            {
                res = res * a;
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine($"Ошибка переполнения при умножении {res} на {a}");
        throw;
    }
    return res;
}