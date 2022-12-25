// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow ( x1-x2 , 2) + Math.Pow ( y1 - y2, 2 ) + Math.Pow ( z1 - z2, 2 ));

Console.WriteLine(dist);