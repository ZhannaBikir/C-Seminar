﻿// Напишите программу, оторая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
    Console.Write(a); 
    Console.Write(" кратно 7 и 23"); 
}
else
{
    Console.Write(a); 
    Console.Write(" не кратно 7 и 23"); 
} 