# 第十次第一題
## 題目
Write a function `timeAdd()` to do time length addition (時間長度加法器). The prototype of the function is as follows.

```c++
void timeAdd(int * hour1, int * minute1, int * second1, int hour2, int minute2, int second2);
```

The two time lengths are stored int the variables <hour1, minute1, second1> and <hour2, minute2, second2>.
The result of addition is stored in <hour1, minute1, second1>.
Note that the values of minutes and seconds are never larger than 59.
Test your `main()` funtion as follow,
```c++
int main() {
    int h1, m1, s1, h2, m2, s2;

    h1 = 3; m1 = 18; s1 = 22; h2 = 5; m2 = 22; s2 = 7;
    printf("%d 小時 %d 分鐘 %d 秒鐘 加上 %d 小時 %d 分鐘 %d 秒鐘\n", h1, m1, s1, h2, m2, s2);
    timeAdd(...);
    printf("\t結果等於 %d 小時 %d 分鐘 %d 秒鐘。\n", h1, m1, s1);

    h1 = 3; m1 = 48; s1 = 32; h2 = 5; m2 = 22; s2 = 57;
    printf("%d 小時 %d 分鐘 %d 秒鐘 加上 %d 小時 %d 分鐘 %d 秒鐘\n", h1, m1, s1, h2, m2, s2);
    timeAdd(...);
    printf("\t結果等於 %d 小時 %d 分鐘 %d 秒鐘。\n", h1, m1, s1);

    h1 = 3; m1 = 88; s1 = 92; h2 = 5; m2 = 122; s2 = 257;
    printf("%d 小時 %d 分鐘 %d 秒鐘 加上 %d 小時 %d 分鐘 %d 秒鐘\n", h1, m1, s1, h2, m2, s2);
    timeAdd(...);
    printf("\t結果等於 %d 小時 %d 分鐘 %d 秒鐘。\n", h1, m1, s1);

    return 0;
}
```
## 範例
```
3 小時 18 分鐘 22 秒鐘 加上 5 小時 22 分鐘 7 秒鐘
　　　　結果等於 8 小時 40 分鐘 29 秒鐘。
3 小時 48 分鐘 32 秒鐘 加上 5 小時 22 分鐘 57 秒鐘
　　　　結果等於 9 小時 11 分鐘 29 秒鐘。
3 小時 88 分鐘 92 秒鐘 加上 5 小時 122 分鐘 257 秒鐘
　　　　結果等於 11 小時 35 分鐘 49 秒鐘。
```