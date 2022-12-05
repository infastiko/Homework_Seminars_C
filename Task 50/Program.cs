// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(String.Format("{0,3}", matrix[i, j]));
    }
    Console.WriteLine();
}

Console.Write("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int col = Convert.ToInt32(Console.ReadLine());

if(row < m && col < n)
{
    Console.WriteLine($"Под данными индексами находится число: {matrix[row, col]}");
}
else
{
    Console.WriteLine($"К сожалению, элемента под индексами {row} и {col} в массиве нет.");
}