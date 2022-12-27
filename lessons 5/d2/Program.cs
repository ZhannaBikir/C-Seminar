// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int [a];
Random rnd = new Random();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i=0; i<myArray.Length; i++)
{
    myArray[i]=rnd.Next(1, 10);
}

for (int i=0; i<myArray.Length; i++)
{
    Console.Write(" " + myArray[i] + " ");
}
Console.WriteLine(" ]");

int summ = 0;
for (int i = 1; i < myArray.Length; i++)
{
    if (i % 2 == 1)
    {
    summ = summ + myArray[i];
    }
}
Console.WriteLine("Сумма нечетных элементов: " + summ);