// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.


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

void ChangeFirstAndLastRow(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        (inputArray[0, i], inputArray[inputArray.GetLength(0) - 1, i]) = (inputArray[inputArray.GetLength(0) - 1, i], inputArray[0, i]);
    }

    System.Console.WriteLine();
    PrintArray(inputArray);
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

Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
Console.WriteLine();
ChangeFirstAndLastRow(array);