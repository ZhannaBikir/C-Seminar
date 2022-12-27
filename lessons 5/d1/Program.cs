// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int [a];
Random rnd = new Random();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i=0; i<myArray.Length; i++)
{
    myArray[i]=rnd.Next(100, 999);
}

for (int i=0; i<myArray.Length; i++)
{
    Console.Write(" " + myArray[i] + " ");
}
Console.WriteLine(" ]");

int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        count = count + 1;
    }

}
Console.WriteLine("Количетво четных чисел = " + count);