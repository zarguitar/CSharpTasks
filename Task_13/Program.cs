// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());


while (num > 999)
{
   num = num / 10;
}
int numshape = num % 10;
 if (num >= 100 && num <=999)
Console.Write($"{numshape}");
else Console.Write("Третьей цифры нет ");
