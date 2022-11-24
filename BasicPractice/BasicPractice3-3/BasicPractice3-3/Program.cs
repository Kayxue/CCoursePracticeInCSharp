// See https://aka.ms/new-console-template for more information

int repeatCount;
Console.Write("How many sets of test data: ");
repeatCount = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatCount; i++)
{
    point p;
    num arg;
    int n;
    Console.Write("\nx1 = ");
    p.x = int.Parse(Console.ReadLine());
    Console.Write("y1 = ");
    p.y = int.Parse(Console.ReadLine());
    Console.Write("a = ");
    arg.a = int.Parse(Console.ReadLine());
    Console.Write("b = ");
    arg.b = int.Parse(Console.ReadLine());
    Console.Write("c = ");
    arg.c = int.Parse(Console.ReadLine());
    Console.Write("r = ");
    arg.r = int.Parse(Console.ReadLine());
    Console.Write("s = ");
    arg.s = int.Parse(Console.ReadLine());
    Console.Write("t = ");
    arg.t = int.Parse(Console.ReadLine());
    Console.Write("n = ");
    n = int.Parse(Console.ReadLine());
    for (int j = 1; j <= n; j++)
    {
        Console.WriteLine($"n = {j}, (x, y) = ({p.x}, {p.y})");
        point oldP = p;
        p.x = arg.a * oldP.x + arg.b * oldP.y + arg.c;
        p.y = arg.r * oldP.x + arg.s * oldP.y + arg.t;
    }
}

struct point
{
    public int x, y;
}

struct num
{
    public int a, b, c, r, s, t;
}