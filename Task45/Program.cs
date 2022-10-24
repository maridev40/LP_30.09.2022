﻿// Задача 45
// Создать копию массива через поэлементное копирование

int[] CreateArrayRndInt(int size, int min, int max)
{
  var array = new int[size];
  var rnd = new Random();

  for (int i = 0; i < size; i++)
  {
      array[i] = rnd.Next(min, max + 1);
  }
  return array;

}

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

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
       newArray[i] = array[i];
    }
    return newArray;
}

int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr); 
int[] newArr = CopyArray(arr);
PrintArray(newArr);