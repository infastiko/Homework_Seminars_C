// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Cross(double b1, double k1, double b2, double k2)
{
    if (b1 == b2 & k1 == k2)
    {
        Console.Write("Прямые совпадают.");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Заданные прямые паралельны и не пересекаются.");
    }    
    else
    {
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
    }
}

Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Cross(b1, k1, b2, k2);
