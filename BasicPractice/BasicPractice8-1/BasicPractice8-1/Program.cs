// See https://aka.ms/new-console-template for more information

void sort3(ref int x, ref int y, ref int z)
{
    if (x > y)
    {
        swap(ref x, ref y);
    }

    if (x > z)
    {
        swap(ref x, ref z);
    }

    if (y > z)
    {
        swap(ref y, ref z);
    }
}

void swap(ref int a, ref int b)
{
    (a, b) = (b, a);
}

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    int x, y, z;
    string[] inputArgs;
    Console.Write("\nPlease input three numbers: ");
    inputArgs = Console.ReadLine()?.Split(" ");
    x = int.Parse(inputArgs[0]);
    y = int.Parse(inputArgs[1]);
    z = int.Parse(inputArgs[2]);
    sort3(ref x, ref y, ref z);
    Console.WriteLine($"Results after sorting: {x}, {y}, {z}");
}
