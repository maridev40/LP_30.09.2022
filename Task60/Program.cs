﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Create3DMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    var matrix = new int[rows, columns, depth];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                //Console.WriteLine($"{i},{j},{k}");
                matrix[i, j, k] = rnd.Next(min, max);
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k], 4}({i, 2},{j, 2},{k, 2}), ");
                else Console.Write($"{matrix[i, j, k], 4}({i, 2},{j, 2},{k, 2}) ");
            }
        }
        Console.WriteLine("|");
    }
}

int[,,] array3D = Create3DMatrixRndInt(4, 3, 2, -10, 10);
Print3DMatrix(array3D);