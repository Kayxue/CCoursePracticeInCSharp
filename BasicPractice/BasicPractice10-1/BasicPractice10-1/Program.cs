// See https://aka.ms/new-console-template for more information
void duplicateStr(ref string des, string src, int repeatTime)
{
    for (int i = 0; i < repeatTime; i++)
    {
        des += src;
    }
}

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    string input;
    string des = "";
    int repeatT;
    Console.Write("\nInput a string: ");
    input = Console.ReadLine();
    Console.Write("Duplicate how many times: ");
    repeatT = int.Parse(Console.ReadLine());
    duplicateStr(ref des, input, repeatT);
    Console.WriteLine($"The new string is [{des}]");
}