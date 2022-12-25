// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, которе хотите проверить: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int [a];
Random rnd = new Random();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i=0; i<myArray.Length; i++)
{
    myArray[i] = rnd.Next(0, 5);
    Console.Write(" " + myArray[i] + " ");
}

Console.WriteLine(" ]");

bool have = false;
for (int i=0; i < myArray.Length; i++)
{
   if (myArray[i] == n) 
   {
       have = true;
       break;
   }
}

if (have) 
{ 
    Console.WriteLine("Число " + n + " присутсвует в массиве");
} 
else
{
    Console.WriteLine("Число " + n + " не присутсвует в массиве");
}

