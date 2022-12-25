// Дан массив размера N. Найти максимальный из его локальных минимумов. 

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

int minIndex = 0;
for (int i = 0; i<myArray.Length; i++)
{
    if (myArray[minIndex]>myArray[i])
    {
        minIndex = i;   
    }
}
Console.WriteLine("Локальные минимумы массива: " + minIndex);