// See https://aka.ms/new-console-template for more information

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    Int64 integer;
    int interval;
    Console.Write("\nPlease input a large integer: ");
    integer = Int64.Parse(Console.ReadLine());
    Console.Write("Please input an interval: ");
    interval = int.Parse(Console.ReadLine());
    Console.WriteLine($"Your input is [{integer}]");
    Console.WriteLine($"Its next 10 numbers by adding {interval} are:");
    for (int k = 0; k < 10; k++)
    {
        integer += interval;
        Console.WriteLine($"{integer}");
    }
    Console.WriteLine("Over!!");
}