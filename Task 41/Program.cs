// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите желаемое количество чисел: ");
int mas = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [mas];
int count = 0;
for(int i = 0; i < arr.Length; i ++)
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    arr[i] = num;
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше 0 равно: {count}");
