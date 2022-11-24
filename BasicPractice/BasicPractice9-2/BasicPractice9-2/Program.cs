// See https://aka.ms/new-console-template for more information

int repeatTime;
Console.Write("How many sets of test data: ");
repeatTime = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTime; i++)
{
    string input;
    int skipping;
    Console.Write("\nInput a string: ");
    input = Console.ReadLine();
    Console.Write("Skipping = ");
    skipping = int.Parse(Console.ReadLine());
    Console.WriteLine($"[{input}]");
    while (input.Length > skipping)
    {
        input = input.Substring(skipping);
        Console.WriteLine($"[{input}]");
    }
}