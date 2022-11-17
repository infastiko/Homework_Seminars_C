Console.Write("Введите число: ");
string num = Console.ReadLine();
int Length = num.Length;
if (num[0] == '-' && Length < 4 || Length < 3) 
{
    Console.WriteLine("В этом числе нет третьей цифры.");
}
else if (num[0] == '-')
{
    Console.WriteLine($"Третья цифра заданного числа: {num[3]}");
}
else if (num[0] != '-')
{
    Console.WriteLine($"Третья цифра заданного числа: {num[2]}");
}