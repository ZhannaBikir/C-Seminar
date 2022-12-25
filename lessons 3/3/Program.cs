// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow ( x1-y1 , 2) + Math.Pow ( x2 - y2, 2 ));

Console.WriteLine(dist);
