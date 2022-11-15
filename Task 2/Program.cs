Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} - большее, {number2} - меньшее.");
}
else if (number1 < number2)
{
    Console.WriteLine($"{number2} - большее, {number1} - меньшее.");
}
else
{
    Console.WriteLine("Вы ввели два равных числа.");
}