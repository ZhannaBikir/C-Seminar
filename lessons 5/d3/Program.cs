// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Double[] myArray;
Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

double[] myArray = new double[a];
Random rnd = new Random();

Console.WriteLine("Вывод массива: ");

for (int i=0; i<myArray.Length; i++)
{
    myArray[i] = rnd.Next(-10, 10) + rnd.NextDouble();
}

for (int i=0; i<myArray.Length; i++)
{
    Console.WriteLine(" " + myArray[i] + " ");
}

double max = 0;
double min = 0;
double b = 0;
for (int i=0; i<myArray.Length; i++)
{
    if (myArray[i] > max)
    {
        max = myArray[i];
    }

    if (myArray[i] < min)
    {
        min = myArray[i];
    }

    b = max - min;
}
Console.Write("Разница между максимальным и минимальным чслом = " + b);