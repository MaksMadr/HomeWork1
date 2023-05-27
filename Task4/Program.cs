Console.Clear();
Console.Write("Введите 1-е число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-е число: ");
int c = int.Parse(Console.ReadLine()!);
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число: " + a);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + c);
    }
}
else if (b > c)
{
    Console.WriteLine("Максимальное число: " + b);
}
else
{
    Console.WriteLine("Максимальное число: " + c);
}