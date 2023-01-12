// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке
// от М о N. Выполнить  помощью рекурсии.

Console.Write("Введите от какого числа: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите до какого числа необходимо вывести все натуральные числа: ");
int n = int.Parse(Console.ReadLine()!);

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumber(start + 1, end));
}

System.Console.WriteLine(PrintNumber(m, n));
