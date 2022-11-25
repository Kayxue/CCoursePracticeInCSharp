# 第十一次第一題
## 題目
Write a function to search a string in a list and returns its index (-1 if not found).

```c++
int indexOfList(char str[], char *list[], int itemTotal);
```

where `str` is the target string, `list` is an array of strings, and `itemTotal` is the number of strings in `list`.
At the beginning of your programming, test `indexOfList()` as follows.

```
Input a line ("quit" to exit): the United Kingdom
Its index is 14.
Input a line ("quit" to exit): cjlin
It is not in the list.
Input a line ("quit" to exit): quit
```

Write a program to provide a database of populations of countries.

## 範例
```
Welcome to the World Population Database!

Input a country ("quit" to exit): the United Kingdom
The population of the United Kingdom is 67509 thousands.

Input a line ("quit" to exit): www
Sorry, we cannot find [www] in our database.

Input a country ("quit" to exit): Singapore
The population of Singapore is 5976 thousands.

Input a line ("quit" to exit): quit

Thank you for using World Population Database!
```