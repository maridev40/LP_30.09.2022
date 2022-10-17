// Задача 26
// Выдать количество цифр в числе

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numbersCount = NumbersCount(number);
Console.WriteLine($"Количесиво цифр в числе: {numbersCount}");

int NumbersCount(int num) {
    
    int count = 0;
    while (num > 0) {
        num = num / 10;
        count++;
    }
    return count;
}