// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество цифр в числе " + a + " = " + a.ToString().Length);