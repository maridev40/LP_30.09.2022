// Задача 40
// Преобразовать десятичное число в двоичное

Console.WriteLine("Введите десятичное число: ");
int dec = Convert.ToInt32(Console.ReadLine());

int Binary(int num)
{
    int temp = 0;
    int count = 1;
    while (num > 0)
    {
        temp = temp + num % 2 * count;
        num = num / 2;
        count = count * 10;
    }
    return temp;
}

int bin = Binary(dec);
Console.WriteLine($"Бинарное число = {bin}");