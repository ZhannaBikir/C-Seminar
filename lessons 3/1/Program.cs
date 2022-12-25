// Напишиет программу, которая принимает на вход координаты точки (х и у), причем х не равняется 0
// и у не равняется 0 и выдает номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введиет у: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть плоскости");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть плоскости");
}

if (x < 0 && y > 0)
{

    Console.WriteLine("2 четверть плоскости");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть плоскости");
}

if (x == 0 || y == 0) 
{
    Console.WriteLine("Невозможно определить четверть плоскости");
}
