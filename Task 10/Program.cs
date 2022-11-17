Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num = -num;
}

if (num < 100 || num > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}
else
{
Console.WriteLine($"Вторая цифра данного числа: {((num / 10) % 10)}");
}
