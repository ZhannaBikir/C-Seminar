// Вычислить: 1 + 2 + 4 + 6 + 8 + . . . + 2 в 10 степени


Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

double number = Math.Pow (a, b);
Console.WriteLine(number);