// Задача 28
// Выдать произведение чисел от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение цифр в числе от 1 до N: {factorial}");

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        try
        {
            checked
            {
                fact = fact * i;
            }
        }
        catch (Exception)
        {
            System.Console.WriteLine($"Переполнение типа на числе {i}");
            break;
        }
    }
    return fact;
}