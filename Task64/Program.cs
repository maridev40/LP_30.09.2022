// Задача 64. Вывести с помощью рекурсии натуральные числа от N до 1

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num == 0)
    {
        return;
    }
    Console.Write($"{num} ");
    NaturalNumbers(num -1 );
}
NaturalNumbers(number); 
