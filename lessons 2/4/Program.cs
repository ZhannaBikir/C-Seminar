// напишите программу, которая принимает на вход 2 числа и проверяет, 
// является ли одно число кадратом другого

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a*a == b && b*b == a)
{
    Console.Write(a); 
    Console.Write(" является квадратом "); 
    Console.WriteLine(b);
}
else
{
    Console.Write(a); 
    Console.Write(" не является квадратом "); 
    Console.Write(b); 
} 