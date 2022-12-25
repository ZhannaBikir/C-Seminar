// SЗадать N и вывести # до N елочкой 
// пример
// N = 3;
//   # 
//  ###
// N = 5
//    # 
//   ###
//  #####
// N = 7
//    # 
//   ###
//  #####
// #######
// Двумерный цикл 
// Если у нас не должно быть # , то пишем пробел

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int centr = number / 2 + 1;
int left = centr - 1;
int right = centr + 1;

if ( number > 0 )
{
    for (int i=1; i<=centr; i++)
    {
        for (int j=0; j<=number; j++)
        {
            if (left<j && right>j)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        left--;
        right++;
        Console.WriteLine();
    }
}
else
{
    Console.Write("Введите положительно число");
}