// Задача 40
// Может ли треуольник иметь три стороны с заданными значениями

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool Triangle (int numA, int numB, int numC) 
{
    return (numA < numB + numC && numB < numC + numA && numC < numB + numA);
} 

bool triangle = Triangle(numberA, numberB, numberC);
if (triangle) Console.WriteLine("Треугольник может существовать");
else Console.WriteLine("Треугольник не может существовать");