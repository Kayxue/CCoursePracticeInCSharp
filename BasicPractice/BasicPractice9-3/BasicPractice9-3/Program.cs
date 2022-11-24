// See https://aka.ms/new-console-template for more information

void reverseString(ref string str)
{
    char[] strArr = str.ToCharArray();
    Array.Reverse(strArr);
    str = new String(strArr);
}

int repeatTimes;
String input;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    Console.Write("\nInput a string: ");
    input = Console.ReadLine();
    reverseString(ref input);
    Console.WriteLine($"The reversed string is [{input}]");
}