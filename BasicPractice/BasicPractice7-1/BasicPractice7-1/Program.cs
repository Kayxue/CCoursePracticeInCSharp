// See https://aka.ms/new-console-template for more information

int GCD(int a, int b)
{
    if (b == 0) return a;
    return GCD(b, a % b);
}

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    int a, b;
    Console.Write("\na = ");
    a = int.Parse(Console.ReadLine());
    Console.Write("b = ");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine($"GCD({a}, {b}) = {GCD(a, b)}");
}