// See https://aka.ms/new-console-template for more information

List<int> rangeCount;
int studentCount, scoreInterval;
Console.Write("Number of students: ");
studentCount = int.Parse(Console.ReadLine());
Console.Write("Score interval: ");
scoreInterval = int.Parse(Console.ReadLine());
rangeCount = new List<int>(new int[(100 / scoreInterval) + 1]);
for (int i = 0; i < studentCount; i++)
{
    Console.Write($"Student#{i + 1}'s score: ");
    int score = int.Parse(Console.ReadLine());
    rangeCount[score / scoreInterval] += 1;
}

Console.WriteLine("\nScoreRange People BarChart");
for (int i = 0; i <= 100; i += scoreInterval)
{
    Console.Write("{0,3} ~ {1,3} {2,5}   ", i, i + scoreInterval - 1, rangeCount[i / scoreInterval]);
    for (int j = 0; j < rangeCount[i / scoreInterval]; j++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}
