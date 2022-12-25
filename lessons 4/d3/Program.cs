// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

 Console.Write("Введите количество элементов массива: ");

 int a = Convert.ToInt32(Console.ReadLine());
 int[] myArray = new int[a]; 

for (int i=0; i<myArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(" " + myArray[i] + " "); 
}

Console.Write(" ]");
Console.ReadLine();