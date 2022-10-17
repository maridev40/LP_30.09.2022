// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] FillArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й из {num} элементов массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[");
        }
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1)
        {
            Console.Write(",");
        }
        else if (i == arr.Length - 1)
        {
            Console.Write("]");
        }
    }
}

int[] myArray = FillArray(8);
PrintArray(myArray);