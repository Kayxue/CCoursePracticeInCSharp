// See https://aka.ms/new-console-template for more information

const double PI = 3.14159265358979323846;

int gcd(int a, int b)
{
    while (b!=0)
    {
        int k = a % b;
        a = b;
        b = k;
    }

    return a;
}

int n;
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
for (int i = 0; i <= 2 * n; i++)
{
    int gcd1 = gcd(i, n);
    Console.WriteLine(
        "x = {0} PI, sin(x) = {1:0.000000}, cos(x) = {2:0.000000}",
        i % n == 0 ? i / n : i / gcd1 + "/" + n / gcd1, Math.Sin(i * 1.0 * PI / n), Math.Cos(i * 1.0 * PI / n));

}