// Найти произведение пар чисел в массиве
// Парой считается Первый и Последний; Второй и Предпоследний и т.д.
// Вернуть результат в массиве

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

int[] NewArray(int[] array)
{
    int size = array.Length / 2;
     if (size % 2 == 1) size++;
     int[] newArr = new int[size];

     for (int i = 0; i < size; i++)
     {
        newArr[i] = array[i] * array[array.Length - i - 1];
     }
     if (array.Length % 2 == 1) newArr[size - 1] = array[size - 1];
     return newArr;
}

int[] arr = CreateArrayRndInt(8, 0, 10);
PrintArray(arr); 

int[] newArr = NewArray(arr);
PrintArray(newArr);
// Console.WriteLine($"Количество элементов : {count}");