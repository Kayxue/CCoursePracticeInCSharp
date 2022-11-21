// See https://aka.ms/new-console-template for more information

bool isPrime(int n)
{
    for (int i = 2; Math.Pow(i, 2) <= n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }

    return true;
}

int repeatTime;
Console.Write("How many sets of test data: ");
repeatTime = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTime; i++)
{
    int num;
    Console.Write("\nInput a number (>= 6): ");
    num = int.Parse(Console.ReadLine());
    for (int j = 2; j <= num; j++)
    {
        for (int k = j; k <= num; k++)
        {
            int l = num - j - k;
            if (isPrime(j) && isPrime(k) && isPrime(l) && j <= k && k <= l)
            {
                Console.WriteLine($"{num} = {j} + {k} + {l}");
            }
        }
    }
}