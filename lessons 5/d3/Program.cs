// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

double[] myArray = new double[a];
Random rnd = new Random();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i=0; i<myArray.Length; i++)
{
    myArray[i] = rnd.Next(1, 10);
}

for (int i=0; i<myArray.Length; i++)
{
    Console.Write(" " + myArray[i] + " ");
}
Console.WriteLine(" ]");