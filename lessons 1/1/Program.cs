Console.Write("Введите А: ");
int A = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите В: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B*B==A)
{
    Console.WriteLine("В является квадратом А");
}

else
{
    Console.WriteLine("В не является квадатом А");
}