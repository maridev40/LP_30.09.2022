// Задача 52
// Найти среднее арифметическое в каждом столбце массива

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

double[] GetColumnAvg(int[,] matrix)
{
    double[] col = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0.0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += Convert.ToDouble(matrix[i, j]);
        }
        col[j] = Math.Round(sum / Convert.ToDouble(matrix.GetLength(0)), 2);
    }
    return col;
}

void PrintColumnAvg(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],4}; ");
        else Console.Write($"{array[i],4} ");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
double[] array2 = GetColumnAvg(array2D);
PrintColumnAvg(array2);
