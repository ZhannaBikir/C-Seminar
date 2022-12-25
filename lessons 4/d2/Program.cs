// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int summ = 0;
int b = a;

while (a>0)
{
   summ = summ + a % 10;
   a = a / 10 ;
}
Console.WriteLine("Сумма чисел " + b + " = " + summ);
