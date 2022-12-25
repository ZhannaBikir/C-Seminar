// Напишите программу, которая выводит случайное трехзначное число и
// удаляет вторую цифру этого числа

using static System.Console;
Clear();

int N = new Random().Next(100, 999);

int M = N/100 * 10 + N%10;

WriteLine (N);
Write (M);