// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введте второе число(обязательно больше первого): ");
int n = int.Parse(Console.ReadLine()!);
int s = 0;

{
    for (int i = m; i <= n; i++)
    {

        s += i;
    }
}

Console.WriteLine("Сумма натуральных элементов от " + m + " до " + n + " = " + s);

