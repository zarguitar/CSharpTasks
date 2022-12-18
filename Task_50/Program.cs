﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

    Console.WriteLine("Задайте позицию i ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте позицию j ");
    int col = Convert.ToInt32(Console.ReadLine());


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

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("[");
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
else Console.Write($"{matrix[i, j], 4} ");
}
Console.WriteLine("]");
}
}

void ShowElementMatrix(int[,] matrix)
{
    if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
        Console.Write($" -> {matrix[row, col]}");
    else
        Console.WriteLine($"{row}, {col} -> такого элемента в массиве нет");
}

int[,] array2D = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array2D);
ShowElementMatrix(array2D);