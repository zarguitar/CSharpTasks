Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) Console.WriteLine($"Число {number1} большее, а {number2} - меньшее ");

if  (number1 < number2) Console.WriteLine($"Число {number2} большее, а {number1} меньшее ");

else 
Console.WriteLine("Числа равны ");