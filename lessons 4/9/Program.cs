// Дан массив размера N. Найти два соседних элемента , сумма которых максимальна, 
// и вывести эти элементы в порядке возратания их индексов.


Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[a];
Random rnd = new Random();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(1, 100);
    Console.Write(" " + myArray[i] + " ");
}
Console.WriteLine(" ]");

int summ = 0;
int max = 0;
int indexA = 0;
int indexB = 0;
 
for (int i = 0; i < myArray.Length - 1; i++)
{
    summ = myArray [i] + myArray [i+1];
     if (summ > max) 
     {
        indexA = myArray[i];
        indexB = myArray[i+1];
        max=summ;
     }
}
Console.WriteLine("Первый элемент массива: " + indexA);
Console.WriteLine("Второй элемент массива: " + indexB);
Console.WriteLine("Сумма элементов массива: " + max);