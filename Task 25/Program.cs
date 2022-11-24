// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int numC = numA;

for(int i = 1; i < numB; i++)
{
    numC = numC * numA;
}

Console.WriteLine($"{numA} в степени {numB} = {numC}");
