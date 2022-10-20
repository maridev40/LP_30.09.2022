// Задача 33
// Найти заданное число в массиве

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

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

bool Find(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
       if (array[i] == num) return true;
    }
    return false;
}

int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr); 

bool find = Find(arr, number);

Console.WriteLine(find ? "Да" : "Нет");