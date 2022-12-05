﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
        Console.Write(String.Format("{0,4}", matrix[i, j]));
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    double average = 0;
    for(int j = 0; j < m; j++)
    {
         average += matrix[j, i];
    }
    Console.WriteLine($"Cреднее арифметическое элементов столбца №{i + 1} = {Math.Round(average / n,1)}");
}