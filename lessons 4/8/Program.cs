internal class Program
{
    private static void Main(string[] args)
    {
        // Дан массив размер N. Найти количество участков, на которых его элементы монотонно 
        // возрастают
        Console.Write("Введите количество элементов массива: ");

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
        
        
        int count = 0;
        for (int i = 2; i < myArray.Length; i++)
        {
            if (myArray[i - 2] < myArray[i - 1] && myArray[i - 1] < myArray[i])            
            {
                count = count + 1;
            }
        }

        Console.WriteLine("Количество возрастаний: " + count);

    }
}