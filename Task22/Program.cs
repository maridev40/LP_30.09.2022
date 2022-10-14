// Задача 22
// Вывести таблицу квадратов от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Square(number);

void Square(int num)
{

    int count = 1;
    while (count <= num)
    {
        int square = count * count;
        Console.WriteLine($"{count} {square}");
        count++;
    }

}