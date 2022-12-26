// Задача 58. Домашняя работа. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

bool MatrixInspect(int[,] matrix, int[,] matrix2)
{
    return (matrix.GetLength(1) == matrix2.GetLength(0));
}

int[,] MatrixMultiply(int[,] matrix, int[,] matrix2)
{
    int[,] matrixMultiply = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    if (MatrixInspect(matrix, matrix2) == true)
    {
        for (int i = 0; i < matrixMultiply.GetLength(0); i++)
        {
            for (int j = 0; j < matrixMultiply.GetLength(1); j++)
            {
                matrixMultiply[i, j] = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrixMultiply[i, j] += matrix[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return matrixMultiply;
}
Console.WriteLine("Первая матрица");
int[,] matrix = CreateMatrixRndInt(3, 5, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
int[,] matrix2 = CreateMatrixRndInt2(5, 3, 1, 9);
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine(MatrixInspect(matrix, matrix2) ? "Результирующая матрица"
: "умножение матриц невозможно");
Console.WriteLine();
int[,] matrixMultiply = MatrixMultiply(matrix, matrix2);
PrintMatrix(matrixMultiply);
