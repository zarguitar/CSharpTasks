// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка



int[,] CreateMatrixRndInt(int rows, int col, int min, int max)
{
    int[,] matrix = new int[rows, col];
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
             Console.Write($"{matrix[i, j],2}{connectIndex}");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine(lastRow);
    }
}
int SumFirstRow(int[,] matrix)
{
    int col = matrix.GetLength(1);
    int summinimal = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < col; j++)
        {
            summinimal += matrix[i, j];
        }
    }
    return summinimal;
}
int MinRowElem(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int summinimal = SumFirstRow(matrix);
    int minElemRow = 0;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < col; j++)
        {
            sum += matrix[i, j];
        }
        if (sum < summinimal)
        {
            summinimal = sum;
            minElemRow = i;
        }
    }
    return minElemRow;
}
int[,] array2D = CreateMatrixRndInt(5, 6, 1, 9);
PrintMatrix(array2D, "", "", "");
int minRowElem = MinRowElem(array2D);
Console.WriteLine();
Console.WriteLine($" {minRowElem + 1}-я строка");

