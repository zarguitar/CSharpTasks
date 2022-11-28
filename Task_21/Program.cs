// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите точку AX ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку AY ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку AZ ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку BX ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку BY ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку BZ ");
int bz = Convert.ToInt32(Console.ReadLine());

double Dist(int ax1, int ay1, int az1, int bx1, int by1, int bz1)
{
    double xc = (ax1 - bx1) * (ax1 - bx1);
    double yc = (ay1 - by1) * (ay1 - by1);
    double zc = (az1 - bz1) * (az1 - bz1);
    double result = Math.Sqrt(xc+yc+zc);
return result;
}

double res = Dist(ax, ay, az, bx, by, bz);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);
