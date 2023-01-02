// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

string bin = Convert.ToString(a, 2);
Console.WriteLine("Число " + a + " в двоичной системе счисления: " + bin);


