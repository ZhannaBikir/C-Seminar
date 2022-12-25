// Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = a.ToString();

if (b.Length < 3)
{
    Console.WriteLine("Третьей цифры, нет ");
}
else
{
Console.WriteLine(a.ToString()[2]);
}