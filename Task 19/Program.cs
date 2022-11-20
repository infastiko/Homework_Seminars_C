Console.Write("Введите пятизначное или шестизначное число: ");
string num = Console.ReadLine();

if (num.Length == 5)
{
    if  ((num[0] == num[4]) && (num[1] == num[3]))
    {
        Console.WriteLine($"Число {num} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {num} НЕ является палиндромом.");
    }

}

else if (num.Length > 5)
{
    if  ((num[0] == num[5]) && (num[1] == num[4]) && (num[2] == num[3]))
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
    Console.WriteLine("Вы ввели число, не входящее в условленные диапазоны, или что-то отличное от числа.");
}