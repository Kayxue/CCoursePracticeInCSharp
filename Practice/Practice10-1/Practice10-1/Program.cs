// See https://aka.ms/new-console-template for more information

unsafe
{
    void timeAdd(int* hour1, int* minute1, int* second1, int hour2, int minute2, int second2)
    {
        *second1 += second2;
        int toAddMinute = 0;
        if (*second1 >= 60)
        {
            toAddMinute = *second1 / 60;
            *second1 %= 60;
        }

        *minute1 += minute2 + toAddMinute;
        int toAddHour = 0;
        if (*minute1 >= 60)
        {
            toAddHour = *minute1 / 60;
            *minute1 %= 60;
        }

        *hour1 += hour2 + toAddHour;
    }

    int h1, m1, s1, h2, m2, s2;
    
    h1 = 3;
    m1 = 18;
    s1 = 22;
    h2 = 5;
    m2 = 22;
    s2 = 7;
    Console.WriteLine($"{h1} 小時 {m1} 分鐘 {s1} 秒鐘 加上 {h2} 小時 {m2} 分鐘 {s2} 秒鐘");
    timeAdd(&h1, &m1, &s1, h2, m2, s2);
    Console.WriteLine($"\t結果等於 {h1} 小時 {m1} 分鐘 {s1} 秒鐘。");
    
    h1 = 3;
    m1 = 48;
    s1 = 32;
    h2 = 5;
    m2 = 22;
    s2 = 57;
    Console.WriteLine($"{h1} 小時 {m1} 分鐘 {s1} 秒鐘 加上 {h2} 小時 {m2} 分鐘 {s2} 秒鐘");
    timeAdd(&h1, &m1, &s1, h2, m2, s2);
    Console.WriteLine($"\t結果等於 {h1} 小時 {m1} 分鐘 {s1} 秒鐘。");
    
    h1 = 3;
    m1 = 88;
    s1 = 92;
    h2 = 5;
    m2 = 122;
    s2 = 257;
    Console.WriteLine($"{h1} 小時 {m1} 分鐘 {s1} 秒鐘 加上 {h2} 小時 {m2} 分鐘 {s2} 秒鐘");
    timeAdd(&h1, &m1, &s1, h2, m2, s2);
    Console.WriteLine($"\t結果等於 {h1} 小時 {m1} 分鐘 {s1} 秒鐘。");
}