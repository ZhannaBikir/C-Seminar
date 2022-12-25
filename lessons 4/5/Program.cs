// Заполнить массив случайными числами (количество элементов с клавиатуры)
// Заполнение в методах , вывод массиа , даже если через string join , 
// то в методе (просто вернуть строку)

Console.Write("Введите количество элементов массива: ");

int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[a]; 
Random rnd = new Random ();

Console.WriteLine("Вывод массива: ");
Console.Write("[ ");

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(-100, 100);
    Console.Write(" " + myArray[i] + " "); 
}

Console.Write(" ]");