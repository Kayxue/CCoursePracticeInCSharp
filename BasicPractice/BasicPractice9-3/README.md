# 第九次作業第三題
## 題目
Write a function  

```c++
void reverseStr(char str[]);
```  

which changes the input string into its reversed version.  
**[Hint] Cf. Slide#32 of Chapter 12**

Use the following main() function to test your function.  
You CANNOT modify this main() function except the ??? part.  

```c++
void reverseStr(char str[]) { ??? }

int main() {
    char inputStr[???];
    int ti, repeatTimes;
    ??? // get repeatTimes from keyboard
    for (ti = 0; ti < repeatTimes; ti++) {
        printf("\nInput a string: ");
        fgets(???);
        reverseStr(inputStr);
        printf("The reversed string is [%s]\n", ???);
    }
    return 0;
}
```