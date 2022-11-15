Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int maxnum = num1;

if (num2 > num1)
{
    maxnum = num2;
}
if (num3 > num2)
{
    maxnum = num3;
}
Console.WriteLine($"Максимальное число - {maxnum}");
