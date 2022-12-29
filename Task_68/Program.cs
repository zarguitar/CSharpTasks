//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int num = -1;
while (num < 0)
{
    Console.WriteLine("Задайте число m ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num < 0) Console.WriteLine("Введены некорректные данные ");
}

int num2 = -1;
while (num2 < 0)
{
    Console.WriteLine("Задайте число n ");
    num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 < 0) Console.WriteLine("Введены некорректные данные ");
}

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if ( n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

Console.Write(Ack(num, num2));


