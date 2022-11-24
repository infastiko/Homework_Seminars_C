// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите желаемую длину массива: ");
int mas = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [mas];
for(int i = 0; i < arr.Length; i ++)
{
    Console.Write("Введите число для массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    arr[i] = num;
}
Console.WriteLine('[' + string.Join(", ", arr) + ']');
