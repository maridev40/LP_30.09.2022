// Задача 24.
// Выдать сумму от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до N: {sumNumbers}");

int SumNumbers(int num)
{
    int sum = default;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}