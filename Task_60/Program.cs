// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

bool InspectNumArr(int[] array, int num)
{
    bool playback = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i])
        {
            return true;
        }
    }
    return playback;
}

int[,,] CreateMatrix3D(int rows, int columns, int depth, int min, int max)
{
    int[,,] mat3D = new int[rows, columns, depth];
    int[] totalNum = new int[rows * columns * depth];
    Random rnd = new Random();
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int temp = 0;
                bool playback = true;
                while (playback == true)
                {
                    temp = rnd.Next(min, max + 1);
                    playback = InspectNumArr(totalNum, temp);
                }
                mat3D[i, j, k] = temp;
                totalNum[index++] = temp;
            }
        }
    }
    return mat3D;
}

void PrintThreeDArray(int[,,] mat3D)
{
    int rows = mat3D.GetLength(0);
    int columns = mat3D.GetLength(1);
    int depth = mat3D.GetLength(2);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                Console.Write($"{mat3D[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] mat3D1 = CreateMatrix3D(2, 2, 2, 10, 99);
PrintThreeDArray(mat3D1);
