// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Rec(int m, int n, int sum)
{
    sum = sum + n;
    if(n <= m)
    {
        Console.WriteLine($"Сумма натуральных элементов между заданными числами = {sum}");
        return;
    }
    Rec(m, n - 1, sum);   
}

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int temp = m;
if (n < m)
{
    m = n;
    n = temp;
}
Rec(m, n, sum);