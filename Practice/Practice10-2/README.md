# 第十次第二題
## 題目
Write a function `strangeFunc()` whose prototype is:

```c++
void strangeFunc(int a[], int size);
```

This function will reverse the locations of negative numbers in the array `a[]`.  
You must use two pointers p and q to do the work as depicted in the following figures.  
Test your main() funtion as follow,
```c++
int main() {
    int a[13] = {65, 0, -5, -22, 9, 231, 43, -7, 11, -65, 0, -18, 65};
    int b[12] = {65, 0, -5, -22, 9, 231, 43, -7, 11, 65, 0, -18};
    int c[12] = {65, 0, 5, 22, 9, 231, 43, 7, 11, 65, 0, 18};

    print the original list in a[];
    print the original list in b[];
    print the original list in c[];

    strangeFunc(a, 13);
    strangeFunc(b...);
    strangeFunc(c...);

    print the modified list in a[];
    print the modified list in b[];
    print the modified list in c[];

    return 0;
}
```
## 範例
```

原先 a[] 為 {65, 0, -5, -22, 9, 231, 43, -7, 11, -65, 0, -18, 65}
原先 b[] 為 {65, 0, -5, -22, 9, 231, 43, -7, 11, 65, 0, -18}
原先 c[] 為 {65, 0, 5, 22, 9, 231, 43, 7, 11, 65, 0, 18}

後來 a[] 為 {65, 0, -18, -65, 9, 231, 43, -7, 11, -22, 0, -5, 65}
後來 b[] 為 {65, 0, -18, -7, 9, 231, 43, -22, 11, 65, 0, -5}
後來 c[] 為 {65, 0, 5, 22, 9, 231, 43, 7, 11, 65, 0, 18}
```