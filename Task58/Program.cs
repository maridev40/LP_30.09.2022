// Задача 58. Найти произведение двух матриц

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

int[,] GetRowMinSum(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            sum = 0;
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                sum += matrix1[i, j] * matrix2[j, k];
            }
            matrix[i, k] = sum;
        }
    }
    return matrix;
}

Console.WriteLine("1 матрица:");
int[,] array1 = CreateMatrixRndInt(4, 2, 0, 10);
PrintMatrix(array1);
Console.WriteLine("2 матрица:");
int[,] array2 = CreateMatrixRndInt(2, 3, 0, 10);
PrintMatrix(array2);
Console.WriteLine("Произведение двух матриц:");
int[,] array = GetRowMinSum(array1, array2);
PrintMatrix(array);
