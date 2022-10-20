﻿// Задача 32
// Заменить в массиве положительные числа на отрицательные и наоборот

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

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      if(i < array.Length - 1) Console.Write($"{array[i]}, ");
      else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void InversionArrayElem(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
       array[i] = -array[i];
    }
}

int[] arr = CreateArrayRndInt(12, -20, 20);
PrintArray(arr); 
InversionArrayElem(arr);
PrintArray(arr);