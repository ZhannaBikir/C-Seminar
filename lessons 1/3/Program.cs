Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;

while(a+1>b)
{
    Console.WriteLine(b);
    b++;
}