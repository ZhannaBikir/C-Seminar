// Вычислить сумму ряда с указанной точностью (е = 0,001)
// 1 + 1/2 + 1/3 + 1/4 + . . . + 1/бесконечность
// Если последнее точность последнего действия меньше чем е, завершаем цикл с помощью break

double summ = 0;
double lastOperation = 0;
int divider = 1;

const double eps = 0.001;

while (true)
{
    lastOperation = (double) 1/divider;
    System.Console.WriteLine(lastOperation);
    summ += lastOperation;
    divider ++;
        if (lastOperation < eps)
        break;
}

System.Console.WriteLine( $"answer = {summ} ");