//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//  в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

 Console.WriteLine("Введите первое число ");
int num = Convert.ToInt32(Console.ReadLine());

 int num2 = -1;
 while (num2 < 1)
 {
     Console.WriteLine("Введите второе число ");
     num2 = Convert.ToInt32(Console.ReadLine());
     if (num2 < 1) Console.WriteLine($"Число {num2} не является натуральным ");
 }

 int Exponentiation(int N, int N2)
 {
      int step = 1;
     for (int i = 1; i <= N2; i++)
     {
       step = (N * step);
     }
    return step;
 }

 int exponentiation = Exponentiation(num, num2);
 Console.Write(exponentiation);



