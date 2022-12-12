// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите точку b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double X(double bx1, double kx1, double bx2, double kx2)
{
    double xx = -(bx1 - bx2) / (kx1 - kx2);
    return xx;
}

double Y(double by1, double ky1)
{
    double xy = X(by1, ky1, b2, k2);
    double yy = ky1 * xy + by1;
    return xy;
}

double x = X(b1, k1, b2, k2);
double y = Y(b1, k1);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({Math.Round(x, 2)}; {Math.Round(y, 2)})");