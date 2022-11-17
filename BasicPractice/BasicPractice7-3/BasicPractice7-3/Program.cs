// See https://aka.ms/new-console-template for more information

int limit;
int n = 1;
void caculate(int a=1, int b=1)
{
    if (a > limit || b > limit) return;
    Console.WriteLine($"n = {n}, (a, b) = ({a}, {b})");
    n++;
    caculate(a + 2 * b + 1, 3 * a - b + 1);
}

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    Console.Write("\nWhat is the upper limit? ");
    limit = int.Parse(Console.ReadLine());
    caculate();
}