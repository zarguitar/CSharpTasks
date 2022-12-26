﻿// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2




int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string firstRow, string connectIndex, string lastRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(firstRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],3}{connectIndex}");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(lastRow);
    }
}

void DescRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int temp;
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns - 1; k++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                if (matrix[i, j + 1] > matrix[i, j])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
}

int[,] array2D = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(array2D, "", "", "");

DescRows(array2D);
Console.WriteLine();
PrintMatrix(array2D, "", "", "");
