// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int num = -1;
while (num < 1)
{
    Console.WriteLine("Задайте число N ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num < 1) Console.WriteLine("Введены некорректные данные ");
}

void ReverseNumbers(int numb)
{
    if (numb < 1) return;
        Console.Write($"{numb} ");
    ReverseNumbers (numb - 1);
   
}

ReverseNumbers(num);

