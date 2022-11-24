// See https://aka.ms/new-console-template for more information

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    Console.WriteLine("\nInput a line:");
    string input = Console.ReadLine();
    Console.WriteLine("Modified line:");
    foreach (char c in input)
    {
        if (!((c >= '0' && c <= '9') || c == '.' || c == '%'))
        {
            Console.Write("_");
        }
        else
        {
            Console.Write(c);
        }
    }
    Console.Write("\n");
}