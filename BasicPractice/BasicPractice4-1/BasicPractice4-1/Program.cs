// See https://aka.ms/new-console-template for more information

Console.WriteLine("Both A and B are matrices with m x n elements.\n");
int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int z = 0; z < repeatTimes; z++)
{
    List<List<int>> matrixA;
    List<List<int>> matrixB;
    int m, n;
    string input;
    Console.Write("\nInput values of m and n: ");
    input = Console.ReadLine();
    string[] arg = input.Split(" ");
    m = int.Parse(arg[0]);
    n = int.Parse(arg[1]);
    matrixA = new List<List<int>>(new List<int>[m]);
    matrixB = new List<List<int>>(new List<int>[m]);
    string[] matrixAValue;
    Console.Write("Input numbers in matrix A: ");
    matrixAValue = Console.ReadLine().Split();
    for (int i = 0; i < m; i++)
    {
        matrixA[i] = new List<int>(new int[n]);
        for (int j = 0; j < n; j++)
        {
            matrixA[i][j] = int.Parse(matrixAValue[n * i + j]);
        }
    }
    string[] matrixBValue;
    Console.Write("Input numbers in matrix B: ");
    matrixBValue = Console.ReadLine().Split();
    for (int i = 0; i < m; i++)
    {
        matrixB[i] = new List<int>(new int[n]);
        for (int j = 0; j < n; j++)
        {
            matrixB[i][j] = int.Parse(matrixBValue[n * i + j]);
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrixA[i][j] += matrixB[i][j];
        }
    }

    Console.Write("{");
    for (int i = 0; i < matrixA.Count; i++)
    {
        Console.Write($"{{{matrixA[i][0]}");
        for (int j = 1; j < matrixA[i].Count; j++)
        {
            Console.Write($", {matrixA[i][j]}");
        }

        Console.Write($"}}{(i == matrixA.Count - 1 ? "" : ",\n")}");
    }
    Console.Write("}\n");
}


