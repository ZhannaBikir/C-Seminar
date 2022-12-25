// Дан массив размера N. Найти номер его перого локального минимума. (Локальный минимум - это 
// элемент, который меньше любого из своих соседей)

Console.Write("Введите количество элементов массива: ");

int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[a]; 
Random rnd = new Random ();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(1, 100);
    Console.Write(" " + myArray[i] + " "); 
}

Console.WriteLine(" ]");

bool CheckParamArray (int[] myArray)
{
    return (myArray.Length <= 1);
}

int CheckLocalMin (int[] myArray)
{
    if (CheckParamArray(myArray))
    return -1;

    for (int i=1; i<myArray.Length - 1; i++)
    {
        int left = myArray[i - 1];
        int middle = myArray[i];
        int right = myArray[i + 1];

        if (left>middle && right>middle)
            return i;
    }
    return -1;
}

int min = CheckLocalMin(myArray);

if (min == -1)
Console.WriteLine("Нет локальнх минимумов");
else
Console.WriteLine("Первый локальный минимум: " + min);
