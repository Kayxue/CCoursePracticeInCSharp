// See https://aka.ms/new-console-template for more information

unsafe void strangeFunc(int[] a)
{
    fixed (int* p1 = a, q2 = &a[a.Length - 1])
    {
        int* p = p1;
        int* q = q2;
        while (p < q && p != q)
        {
            while (*p >= 0)
            {
                if (p >= q) return;
                p += 1;
            }

            while (*q >= 0)
            {
                if (p >= q) return;
                q -= 1;
            }
            swap(ref *p, ref *q);
            p += 1;
            q -= 1;
        }
    }
}

void swap(ref int a, ref int b)
{
    (a, b) = (b, a);
}

void printArray(bool after, string name, int[] arr)
{
    Console.Write($"{(after?"後來":"原先")} {name}[] 為 {{{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("}\n");
}

int[] a = { 65, 0, -5, -22, 9, 231, 43, -7, 11, -65, 0, -18, 65 },
    b = { 65, 0, -5, -22, 9, 231, 43, -7, 11, 65, 0, -18 },
    c = { 65, 0, 5, 22, 9, 231, 43, 7, 11, 65, 0, 18 };

printArray(false,"a",a);
printArray(false,"b",b);
printArray(false,"c",c);

strangeFunc(a);
strangeFunc(b);
strangeFunc(c);

printArray(true,"a",a);
printArray(true,"b",b);
printArray(true,"c",c);
