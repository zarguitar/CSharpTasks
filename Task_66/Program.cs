// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int num = -1;
while (num < 1)
{
    Console.WriteLine("Задайте число M ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num < 1) Console.WriteLine("Введены некорректные данные ");
}

int num2 = -1;
while (num2 < 1)
{
    Console.WriteLine("Задайте число N ");
    num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 < 1) Console.WriteLine("Введены некорректные данные ");
}

int SumNatDig(int n1, int n2)
{
    if (n1 == n2) return n1;
    else if (n1 < n2) return n2 + SumNatDig(n1, n2 - 1);
    else return n2 + SumNatDig(n1, n2 + 1);
}

Console.Write(SumNatDig(num, num2));
