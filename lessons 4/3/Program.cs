// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int n = 1;

for ( int i = 1; i <= A; i++)
{
    n = n * i;
}

Console.WriteLine("Произведение чисел от 1 до " + A + " = " + n);