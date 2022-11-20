Console.WriteLine("Введите координату x точки A: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки A: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки A: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));

Console.WriteLine($"Расстояние между заданными точками в 3D пространстве: {distance}");