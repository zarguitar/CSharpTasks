// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру ");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Weekend(day) ? "Да" : "Нет");

bool Weekend (int daily)
{
    return (daily ==6) || (daily == 7); 
}
