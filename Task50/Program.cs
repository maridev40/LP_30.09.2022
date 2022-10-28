// Задача 50
// Вернуть значение элемента с заданной позицией в двумерном массиве

Console.Write("Введите i: ");
int inum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j: ");
int jnum = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

bool ExistElement(int[,] array, int x, int y)
{
    return (x >= 0 && x <= array.GetLength(0)
      && y >= 0 && y <= array.GetLength(1));
}

void FindElement(int[,] array, int x, int y)
{
    if (ExistElement(array, x, y))
    {
        Console.WriteLine($"{x}, {y} -> {array[x, y]}");
    }
    else
    {
        Console.WriteLine($"{x}, {y} -> такого элемента в массиве нет");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
FindElement(array2D, inum, jnum);
