Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
    if ((count % 2) == 0)
    {
        Console.WriteLine(count);
        count += 1;
    }
    else
    {
        count += 1;
    }
}
