// See https://aka.ms/new-console-template for more information
void meanValue(double a, double b, ref double aMean, ref double gMean, ref double hMean)
{
    aMean = (a + b) / 2;
    gMean = Math.Sqrt(a * b);
    hMean = a + b == 0 ? 0 : 2 * a * b / (a + b);
}

int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int i = 0; i < repeatTimes; i++)
{
    double a, b, aMean = 0, gMean = 0, hMean = 0;
    string[] arg;
    Console.Write("\nPlease input two numbers: ");
    arg = Console.ReadLine()?.Split(" ");
    a = double.Parse(arg[0]);
    b = double.Parse(arg[1]);
    meanValue(a, b, ref aMean, ref gMean, ref hMean);
    Console.WriteLine("The arithmetic mean of {0:0.000000} and {1:0.000000} is {2:0.000000}", a, b, aMean);
    Console.WriteLine("The geometric mean of {0:0.000000} and {1:0.000000} is {2:0.000000}", a, b, gMean);
    Console.WriteLine("The harmonic mean of {0:0.000000} and {1:0.000000} is {2:0.000000}", a, b, hMean);
}