// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите число m ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n ");
// int n = Convert.ToInt32(Console.ReadLine());

int m = -1;
int n = -1;
while (m < 1) 
{
    Console.WriteLine("Задайте параметр m ");
    m = Convert.ToInt32(Console.ReadLine());
    if (m < 1) Console.WriteLine("Введены некорректные данные ");
}

while (n < 1) 
{
    Console.WriteLine("Задайте параметр n ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены некорректные данные ");
}

double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

double[,] array2D = CreateMatrixRndDouble(m, n, -100, 99); 
PrintMatrix(array2D);