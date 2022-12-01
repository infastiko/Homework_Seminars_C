// Дополнительная задача на рекурсию (необязательная)
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

void countNumber(int num, int count)
{
    if (num == 0)
    {
        Console.WriteLine($"Количество цифр в заданном числе: {count}");
        return;
    }
    countNumber(num / 10, count = count + 1);
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
countNumber(num, count);
