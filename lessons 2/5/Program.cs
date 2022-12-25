// Дано натульаное число а. Вычислить: 1 + 1/2 + 1/3 + 1/4 + . . . + 1/а

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

double summa = 1;
for (int i = 1; i <= a; i++)
{
    summa = summa + (double)1 / i;
}

Console.WriteLine(summa.ToString());
