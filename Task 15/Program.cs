Console.Write("Введите число от 1 до 7, чтобы узнать является ли выбранный день выходным: ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day == 1)
{
    Console.WriteLine("Понедельник - будний день.");
}
else if (Day == 2)
{
    Console.WriteLine("Вторник - будний день.");
}
else if (Day == 3)
{
    Console.WriteLine("Среда - будний день.");
}
else if (Day == 4)
{
    Console.WriteLine("Четверг - будний день.");
}
else if (Day == 5)
{
    Console.WriteLine("Пятница - будний день.");
}
else if (Day == 6)
{
    Console.WriteLine("Суббота - выходной день.");
}
else if (Day == 7)
{
  Console.WriteLine("Воскресенье - выходной день.");
}
else
{
    Console.WriteLine("Вы ввели другое число.");
}
