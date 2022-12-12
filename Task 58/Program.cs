// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] ResultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

Console.Write("Введите количество строк 1 массива: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int col1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int col2 = Convert.ToInt32(Console.ReadLine());

if (col1 != row2)
{
    Console.WriteLine("Эти матрицы нельзя перемножить!");
}

int[,] matrix1 = FillMatrix(row1, col1);
int[,] matrix2 = FillMatrix(row2, col2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();

// // Вариант проверки задачи из условия.
// int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
// int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };
// PrintMatrix(matrix1);
// Console.WriteLine();
// PrintMatrix(matrix2);
// Console.WriteLine();

PrintMatrix(ResultMatrix(matrix1, matrix2));
