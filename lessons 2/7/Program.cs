//Необходимо вывести все квадраты натуральных чисел не превосходящие входного числа

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i*i<=a)
{
    if (i*i<a)
    {
    Console.WriteLine(i*i);
    }
i++;
}