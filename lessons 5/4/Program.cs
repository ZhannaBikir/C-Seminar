// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] myArray = new int[123];
Random rnd = new Random();

int count = 0;

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(0, 150);
    Console.Write(" " + myArray[i] + " ");
}

Console.WriteLine(" ]");

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 10 && myArray[i] < 99)
    {
        count = count + 1;
    }
}
Console.WriteLine("Количество элементов от 10 до 99: " + count);
