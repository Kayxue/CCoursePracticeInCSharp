// See https://aka.ms/new-console-template for more information

int[] endDate = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

bool isLeapYear(int year)
{
    return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
}

bool isInvalidDate(int year, int month, int day)
{
    if (month is < 1 or > 12 || day < 1) return true;
    return day > (month == 2 ? isLeapYear(year) ? 29 : 28 : endDate[month - 1]);
}

int repeatTime;
Console.Write("How many sets of test data: ");
repeatTime = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTime; i++)
{
    string input;
    int[] arg = new int[3];
    Console.Write("\nInput a date (year/month/day): ");
    input = Console.ReadLine();
    arg = input.Split("/").Select(e => int.Parse(e)).ToArray();
    Console.WriteLine($"{input} is {(isInvalidDate(arg[0], arg[1], arg[2]) ? "not " : "")}a valid date.");
}