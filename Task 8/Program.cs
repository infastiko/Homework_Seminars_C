Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count < (num -1))
{
    count += 2;
    Console.WriteLine(count);
}