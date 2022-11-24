// See https://aka.ms/new-console-template for more information

Console.WriteLine("A is a matrix with m x n elements and\nB is a matrix with n x p elements.\n");
int repeatTimes;
Console.Write("How many sets of test data: ");
repeatTimes = int.Parse(Console.ReadLine());
for (int z = 0; z < repeatTimes; z++)
{
    List<List<int>> matrixA;
    List<List<int>> matrixB;
    List<List<int>> matrixC;
    int m, n, p;
    string input;
    Console.Write("\nInput values of m, n, p: ");
    input = Console.ReadLine();
    string[] arg = input.Split(" ");
    m = int.Parse(arg[0]);
    n = int.Parse(arg[1]);
    p = int.Parse(arg[2]);
    matrixA = new List<List<int>>(new List<int>[m]);
    matrixB = new List<List<int>>(new List<int>[n]);
    matrixC=new List<List<int>>(new List<int>[m]);
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
    for (int i = 0; i < n; i++)
    {
        matrixB[i] = new List<int>(new int[p]);
        for (int j = 0; j < p; j++)
        {
            matrixB[i][j] = int.Parse(matrixBValue[p * i + j]);
        }
    }

    for (int i = 0; i < m; i++)
    {
        matrixC[i] = new List<int>(new int[p]);
        for (int j = 0; j < p; j++)
        {
            int sum = 0;
            for (int k = 0; k < n; k++)
            {
                sum += matrixA[i][k] * matrixB[k][j];
            }
            matrixC[i][j] = sum;
        }
    }

    Console.Write("{");
    for (int i = 0; i < matrixC.Count; i++)
    {
        Console.Write($"{{{matrixC[i][0]}");
        for (int j = 1; j < matrixC[i].Count; j++)
        {
            Console.Write($", {matrixC[i][j]}");
        }

        Console.Write($"}}{(i == matrixC.Count - 1 ? "" : ",\n")}");
    }
    Console.Write("}\n");
}


