// See https://aka.ms/new-console-template for more information

int finalIndex;
int nowA = 0;
void mya(int k, int m, int n, int s, int t)
{
    if (k > finalIndex) return;
    Console.WriteLine($"a_{k} = {nowA}");
    nowA = k % 2 == 0 ? m * nowA + n : s * nowA + t;
    mya(k + 1, m, n, s, t);
}

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    int m, n, s, t;
    Console.Write("\nm = ");
    m = int.Parse(Console.ReadLine());
    Console.Write("n = ");
    n = int.Parse(Console.ReadLine());
    Console.Write("s = ");
    s = int.Parse(Console.ReadLine());
    Console.Write("t = ");
    t = int.Parse(Console.ReadLine());
    Console.Write("Final index = ");
    finalIndex = int.Parse(Console.ReadLine());
    mya(0, m, n, s, t);
    nowA = 0;
}