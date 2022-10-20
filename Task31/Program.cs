﻿// Задача 31

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

int[] GetSumPositiveNegativeElem (int[] array)
{
  int sumNegative = default;
  int sumPozitive = default;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < 0) sumNegative += array[i];
    else sumPozitive += array[i];
  }

  return new int[] {sumNegative, sumPozitive};
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr); 
int[] result = GetSumPositiveNegativeElem(arr);

Console.WriteLine($"Сумма положительных чисел = {result[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {result[0]}");