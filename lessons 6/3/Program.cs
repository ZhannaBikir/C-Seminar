﻿// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 0;
int c = 1;
int d;

Console.Write(b + " " + c + " ");

for (int i = 3; i <= a; i++)
{
    d = b + c;
    Console.Write(d + " ");
    b = c;
    c = d;
}