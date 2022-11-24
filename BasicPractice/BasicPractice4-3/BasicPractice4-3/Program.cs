// See https://aka.ms/new-console-template for more information

double myPower(double x, int y)
{
    if (y == 0)
    {
        return 1;
    }

    return x * myPower(x, y - 1);
}

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    double x;
    int n;
    Console.Write("\nx = ");
    x = double.Parse(Console.ReadLine());
    Console.Write("n = ");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("power({0:0.000000}, {1}) = {2:0.000000}", x, n, myPower(x, n));
}