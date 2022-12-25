// Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int [a];
Random rnd = new Random();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i=0; i<myArray.Length; i++)
{
    myArray[i]=rnd.Next(-9, 9);
    Console.Write(" " + myArray[i] + " ");
}

Console.WriteLine(" ]");
Console.WriteLine("Вывод нового массива: ");
Console.Write("[ ");

for (int j=0; j<myArray.Length; j++)
{
    if (myArray[j]>0 || myArray[j]<0)
        {
            myArray[j] = myArray[j] * -1;
        }
        Console.Write(" " + myArray[j] + " ");
}
Console.WriteLine(" ]");
