Console.Write("Введите пятизначное или шестизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    if  ((num / 10000 == num % 10) && (((num / 1000) % 10) == (num / 10) % 10))
    {
        Console.WriteLine($"Число {num} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {num} НЕ является палиндромом.");
    }

}

else if (num > 99999 && num < 1000000)
{
    if  ((num / 100000 == num % 10) && ((num / 10000) % 10) == ((num / 10) % 10) && ((num / 1000) % 10) == ((num / 100) % 10))
    {
        Console.WriteLine($"Число {num} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {num} НЕ является палиндромом.");
    }

}

else
{
    Console.WriteLine("Вы ввели число, не входящее в условленные диапазоны.");
}