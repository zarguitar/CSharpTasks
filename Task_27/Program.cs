// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int SumCombo(int N)
{
    int sum = 0;
     while (N > 0)
     {
       sum = sum + N % 10;
       N = N / 10;
     }
    return sum;
}
int sumcombo = SumCombo(num);
Console.Write($"{num} --> {sumcombo}");