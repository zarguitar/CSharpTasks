// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

 int GetPosElem(int[] arr)
 {
     int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        result++;
    }
         return result; 
 }

int[] array = CreateArrayRndInt(m, -999, 1000);
 PrintArray(array);
 int getposelem = GetPosElem(array);
 Console.Write ($" -> {getposelem} ");