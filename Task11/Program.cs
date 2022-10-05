int number = new Random().Next(100, 1000);
Console.WriteLine($"Rundom number from 100 - 999 -> {number}");
int firstDigit = number / 100;
int secondDigit = number % 10;
int twoNumber = firstDigit * 10 + secondDigit;
Console.WriteLine($"две цифры {twoNumber}");