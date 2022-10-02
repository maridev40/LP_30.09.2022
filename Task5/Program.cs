Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Все целые числа в промежутке от {-number} до {number}");

int counter = -number;
while (counter <= number){
    Console.Write($"{counter} ");
    counter++;
}
