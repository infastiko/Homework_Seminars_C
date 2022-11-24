// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (num < 0)
{
    num = -num;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
        if (num < 10)
        {
            num = -num;
        }
    }
}
else
{
    while (num != 0)
    {
    sum = sum + num % 10;
    num = num / 10;
    }
}
Console.WriteLine($"Сумма цифр в этом числе равна: {sum}");
