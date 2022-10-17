// Задача 30
// Вывести массив из 8 элементов

int[] FillArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}

int[] myArray = FillArray(8);
PrintArray(myArray);