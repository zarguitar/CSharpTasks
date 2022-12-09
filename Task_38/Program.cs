// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i],1)}, ");
        else Console.Write($"{Math.Round(arr[i],1)} ");
    }
    Console.Write("]");
}

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArray(array);

double CatchMaxNum(double[] arr)
{
    double maxnum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxnum) maxnum = arr[i];
    }
    return maxnum;
}

double CatchMinNum(double[] arr)
{
    double minnum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minnum) minnum = arr[i];
    }
    return minnum;
}

double catchmaxNum = CatchMaxNum(array);
double catchminnum = CatchMinNum(array);
double difference = catchmaxNum - catchminnum;
Console.Write ($" -> {Math.Round(difference, 1)} ");