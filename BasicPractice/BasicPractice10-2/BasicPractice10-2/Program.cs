// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

void keywordMasking(ref string sentence, string keyword)
{
    string mask = "";
    for (int i = 0; i < keyword.Length; i++)
    {
        mask += "#";
    }
    Regex regex = new Regex(keyword);
    while (regex.Count(sentence) > 0)
    {
        sentence = regex.Replace(sentence, mask);
    }
}

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    string sentence, keyword;
    Console.Write("\nInput a sentence: ");
    sentence = Console.ReadLine();
    Console.Write("Input a keyword: ");
    keyword = Console.ReadLine();
    keywordMasking(ref sentence, keyword);
    Console.WriteLine($"The masked sentence is [{sentence}]");
}
