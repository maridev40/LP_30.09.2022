Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b == a * a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}