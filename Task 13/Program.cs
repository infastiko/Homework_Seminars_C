Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 && num > -100)
{
    Console.WriteLine($"В числе {num} нет третьей цифры.");
}

if (num < 0)
{
    num = -num;
}

while (num > 999)
{
    num = (num / 10);
}
    
if (num > 99 && num < 1000)
{
    Console.WriteLine($"Третья цифра заданного числа: {num % 10}"); 
}
