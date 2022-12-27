// Дан массив размера N. Найти максимальный из его локальных минимумов. 

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");

        int a = Convert.ToInt32(Console.ReadLine());
        int[] myArray = new int[a];
        Random rnd = new Random();
        int[] myArray2 = new int[a];

        Console.WriteLine("Вывод массива: ");
        Console.Write("[ ");

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = rnd.Next(1, 100);
            Console.Write(" " + myArray[i] + " ");
        }

        Console.WriteLine(" ]");

        for (int i = 1; i < myArray.Length - 1; i++)
        {
            int left = myArray[i - 1];
            int middle = myArray[i];
            int right = myArray[i + 1];

            if (left > middle && right > middle)
            {
                myArray2[i] = middle;
               // Console.WriteLine(" " + myArray2[i] + " ");
            }
        }
        
        int max = 0;
        for (int i = 0; i < myArray2.Length; i++)
        {
            if (myArray2[i] > max)
            {
                max = myArray2[i];
            }
        }

        Console.Write("Максимальное из локальных минимумов: " + max);
    }
}
