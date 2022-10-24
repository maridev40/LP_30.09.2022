// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел: ");
string nums = Console.ReadLine();

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] ConvertToInt(string[] array)
{
    int[] arr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = Convert.ToInt32(array[i]);
    }
    return arr;
}

int GetCountN(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(nums);

string[] arrStr = nums.Split(" ");
int[] arrInt = ConvertToInt(arrStr);
PrintArray(arrInt);

int count = GetCountN(arrInt);
Console.WriteLine($"Количество чисел больше нуля = {count} ");


