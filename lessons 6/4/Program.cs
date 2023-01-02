// Напишите программу, которая будет создавать копию заданного массива с помощью 
// поэлементного копирования.

Console.Write("Введите колличество элементов в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[a];
Random rnd = new Random();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(0, 150);
    Console.Write(" " + myArray[i] + " ");
}

Console.WriteLine(" ]");

int[] copy = new int[myArray.Length];
myArray.CopyTo(copy, 0);

Console.Write("[ ");
Console.Write(String.Join(", ", copy));
Console.WriteLine(" ]");