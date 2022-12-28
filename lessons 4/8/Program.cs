internal class Program
{
    private static void Main(string[] args)
    {
        // Дан массив размер N. Найти количество участков, на которых его элементы монотонно 
        // возрастают
        Console.Write("Введите количество элементов массива: ");
        int a = Convert.ToInt32(Console.ReadLine());

        int[] myArray = new int[a];
        myArray = FillArrayRandomNumbers(myArray, 0, 100);


        // int[] myArray = { 9, 1, 2, 3, 3, 3, 1, 2, 2, 3, 4, 3, 2, 1 };

        Console.WriteLine("Созданный массив:");
        WriteLineArray(myArray);

        int count = GetTrendCount(myArray);

        Console.WriteLine("Количество возрастаний: " + count);
    }

    private static void WriteLineArray(int[] array)
    {
        Console.Write("[");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" " + array[i].ToString() + ", ");
        }

        Console.Write("]");

        Console.WriteLine();
        Console.WriteLine();
    }

    private static int[] FillArrayRandomNumbers(int[] array, int min = 0, int max = 100)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max);
        }

        return array;
    }

    private static int GetTrendCount(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (
                // Если мы не вышли из массива - i != myArray.Length - 1
                // и мы в тренде - myArray[i] <= myArray[i + 1]
                i != array.Length - 1 && array[i] <= array[i + 1] ||

                // Если мы первый элемент и мы больше второго элемента, 
                // то есть мы по умолчанию уже не в тренде (скипаем)
                i == 0 && array[i] > array[i + 1] ||
                
                i >= 0 && i <= array.Length - 2 && array[i] > array[i + 1] ||

                // Если последний элемент меньше предпоследнего
                i == array.Length - 2 && array[i] > array[i + 1]
            )
            {
                continue;
            }
            else
            {
                count++;
            }
        }

        return count;
    }
}