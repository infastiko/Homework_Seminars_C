// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetMatrix(int[] size, int min, int max)
{
    int[,,] result = new int[size[0], size[1], size[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int item = new Random().Next(min, max + 1);
                if (FindElement(result, item)) continue;
                result[i, j, k] = item;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] matrix, int element)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == element) return true;
            }
        }
    }
    return false;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[] nums = {2, 2, 2};
int[,,] matrix = GetMatrix(new int[] { (nums[0]), (nums[1]), (nums[2]), }, 10, 99);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Введите индексы элемента.");
Console.WriteLine("Введите первый индекс: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй индекс: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третий индекс: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write($"Под заданными индексами находится - {matrix[x, y, z]}");
