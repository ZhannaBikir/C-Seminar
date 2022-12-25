// Напишите программу, которая будет принимать на вход два числа и выводить, 
// вляется ли второе число кратным первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a%b == 0)
{
    Console.Write(a); 
    Console.Write(" кратно "); 
    Console.WriteLine(b);
}
else
{
    Console.Write(a); 
    Console.Write(" не кратно "); 
    Console.Write(b); 
    Console.Write(", остаток "); 
    Console.WriteLine(a%b);
} 