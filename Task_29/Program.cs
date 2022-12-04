// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] ara = new int[8];

void ShowAra(int[] ara)
{
    Random ran = new Random();
    for (int i = 0; i < ara.Length; i++)
    {
        ara[i] = ran.Next(0, 34);
       
    }
}

void PrintAra(int[] ara)
{
    for (int i = 0; i < ara.Length; i++)
    {
        Console.Write($"[{ara[i]}]");
    }
}

ShowAra(ara);
PrintAra(ara);