// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
string num = Console.ReadLine();
int sum = 0;
if(num[0] == '-')
{
    int x = Convert.ToInt32(num.Substring(0, 2));
    sum = sum + x;
    for(int i = 2; i < num.Length; i++)
    {
        sum = sum + Convert.ToInt32(num.Substring(i, 1));
    }
}
else if (num[0] != '-')
{
    for (int i = 0; i < num.Length; i++)
    {
    sum = sum + Convert.ToInt32(num.Substring(i, 1));
    }
}
Console.WriteLine($"Сумма цифр в заданном числе равна: {sum}");