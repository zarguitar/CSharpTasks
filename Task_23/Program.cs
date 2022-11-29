// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int num = -1;
while (num < 1)
{
    Console.WriteLine("Введите число ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num < 1) Console.WriteLine("Введены некорректные данные ");
}

void CubeTable(int num1)
{
    for (int i = 1; i<=num1; i++)
    {
          Console.WriteLine($"{i}|{i * i * i} \n");
    }
}
CubeTable(num);

// string CubeTable(int num1)
// {
//    int i = 1;
//    string tab = "";
//    while (i <= num1)
//    {
//     tab = tab + ($"{i}|{i * i * i} \n");
//     i++;
//     return tab;
//    }
// }
// string cubetable = CubeTable(num);
// Console.WriteLine(cubetable);
