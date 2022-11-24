// See https://aka.ms/new-console-template for more information

int studentCount;
int[] monthCount = new int[12];
Console.Write("請問有幾位同學？");
studentCount = int.Parse(Console.ReadLine());
Console.WriteLine("請輸入他們的生日 (格式為 年/月/日)。");
for (int i = 0; i < studentCount; i++)
{
    string input = Console.ReadLine();
    int month = int.Parse(input.Split("/")[1]);
    monthCount[month - 1] += 1;
}
for (int i = 0; i < 12; i++)
{
    Console.WriteLine($"{i + 1}月出生的有 {monthCount[i]} 位");
}
