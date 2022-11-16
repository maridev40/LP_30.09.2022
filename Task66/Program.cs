// Задача 66. Найти сумму натуральных чисел от M до N

int SumNumber(int m, int n)
{

    if (m == n)
    {
        return m;
    }
    return m + SumNumber(m + 1, n);
}
int sum = SumNumber(4, 8);
Console.WriteLine($"Сумма элементов равна {sum}");