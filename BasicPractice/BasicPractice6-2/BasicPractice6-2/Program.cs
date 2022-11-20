// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();
foreach (char c in input)
{
    Console.WriteLine($"[{c}] {(int)c} ==> [{(char)(c + 1)}] {c+1}");
}