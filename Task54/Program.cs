// Задача 54. Упорядочить элементы на убывание строк
//  двумерного массива

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

void SetOrderRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k - 1] < matrix[i, k])
                {
                    int tmp = matrix[i, k];
                    matrix[i, k] = matrix[i, k - 1];
                    matrix[i, k - 1] = tmp;
                }
            }
        }
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
Console.WriteLine("Сортировка строк на убывание:");
SetOrderRows(array2D);
PrintMatrix(array2D);
