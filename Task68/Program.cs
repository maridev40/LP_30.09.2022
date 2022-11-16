// Задача 68. Вычислить функцию Аккермана

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {

        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
int sum = Akkerman(m, n);
Console.WriteLine($"A(m={m}, n={n}) = {sum}");
