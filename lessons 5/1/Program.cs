// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] myArray = new int [12];
Random rnd = new Random();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");
int summmin = 0;
int summmax = 0;

for (int i=0; i<myArray.Length; i++)
{
    myArray[i]=rnd.Next(-9, 10);
    Console.Write(" " + myArray[i] + " ");
}

Console.WriteLine(" ]");

for (int j=0; j<myArray.Length; j++)
{
    if (myArray[j]>=0)
        {
            summmax = summmax + myArray[j];
        }
    else
        {
            summmin = summmin + myArray[j];
        }
}

Console.WriteLine("Сумма положтельных чисел: " + summmax);
Console.WriteLine("Сумма трицательных чисел: " + summmin);