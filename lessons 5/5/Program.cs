// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int [a];
Random rnd = new Random();
int summ = 0; 

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i=0; i<myArray.Length; i++)
{
    myArray[i]=rnd.Next(1, 10);
}

for (int i=0; i<myArray.Length; i++)
{
    Console.Write(" " + myArray[i] + " ");
}
Console.WriteLine(" ]");

Console.WriteLine("Вывод нового массива: ");
Console.Write("[ ");

for (int i=0, j=myArray.Length - 1; i<myArray.Length / 2; i++, j--)
{
    summ = myArray[i] * myArray[j];


    Console.Write(" " + summ + " ");
}
Console.WriteLine(" ]");




    