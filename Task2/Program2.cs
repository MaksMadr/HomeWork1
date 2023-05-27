Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()!);
if (n > m)
    Console.WriteLine($"{n} больше {m}");
else if (m > n)
    Console.WriteLine($"{m} больше {n}");
else
    Console.WriteLine($" 1-ое число {m} равно 2-ому числу {n}");