// See https://aka.ms/new-console-template for more information

unsafe
{
    void pay_amount(int dollars, int* fifties, int* tens, int* fives, int* ones)
    {
        *fifties = dollars / 50;
        dollars %= 50;
        *tens = dollars / 10;
        dollars %= 10;
        *fives = dollars / 5;
        dollars %= 5;
        *ones = dollars;
    }

    int repeatTimes;
    Console.Write("How many sets of test data: ");
    repeatTimes = int.Parse(Console.ReadLine());
    for (int i = 0; i < repeatTimes; i++)
    {
        int dollar, num50, num10, num5, num1;
        Console.Write("\nPlease enter the price: ");
        dollar = int.Parse(Console.ReadLine());
        pay_amount(dollar, &num50, &num10, &num5, &num1);
        Console.Write($"You need {num1 + num5 + num10 + num50} coin(s), including:\n");
        Console.Write($"\t$50: {num50}\n");
        Console.Write($"\t$10: {num10}\n");
        Console.Write($"\t$5: {num5}\n");
        Console.Write($"\t$1: {num1}\n");
    }
}