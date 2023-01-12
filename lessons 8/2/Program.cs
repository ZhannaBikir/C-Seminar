// Задайте двумерный массив. Напишите программу, которая заменяет стркои на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] inArray)
{
    int[,] temparray = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i += 1)
        for (int j = 0; j < inArray.GetLength(1); j++)

            temparray[i, j] = inArray[j, i];

    return temparray;
}

Console.WriteLine();
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
if (rows != cols)
    Console.WriteLine("Строки со столбцами поменять нельзя.");
else
{
    int[,] myArray = GetArray(rows, cols, 0, 10);
    PrintArray(myArray);
    Console.WriteLine();
    PrintArray(ChangeArray(myArray));
}