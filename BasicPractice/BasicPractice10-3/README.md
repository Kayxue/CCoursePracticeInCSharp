# 第十次作業第三題
## 題目
Define a new structure type called FishData to store information of fish including:

|屬性欄位 Member/Field|意義 Meaning| 資料型態 Data Type                                                     |
|-----|-----|--------------------------------------------------------------------|
|engName|英文名 English name| a string including more than one word                              |
|sciName|學名 scientific name| a string including more than one word                              |
|avgLength|平均身長 average length (cm)| integer                                                            |
|avgWeight|平均體重 average weight (g)| integer, -1 means no data                                          |
|environment|養殖環境 environment| character.  `'S'` for seawater fish and  `'F'` for freshwater fish |

Declare an array of the `FishData` structures and
save the following data into the array as initial values.  
**[Hint] Set initial values at the time of declaration.**

| 英文名 English name | 學名 scientific name | 平均身長 average length | 平均體重 average weight | 養殖環境 environment |
|------------------|--------------------|---------------------|---------------------|------------------|
| Milk Fish        | Chanos chanos      | 40                  | 300                 | S                |
|Black King Fish|Rachycentron canadum|150|40000|S|
|Grass carp|Ctenopharyngodon idella|150|35000|F|
|Gold Head Cichlid|Aulonocara baenschi|15|-1|F|
|Ocellaris clownfish|Amphiprion ocellaris|4|-1|S|

Allow the user to search this database several times until s/he inputs **quit**.

Print out fish descriptions as shown in the examples.
**Note that -1 means a field contains "no data" thus no need to be shown.**

**Programs not using structures will receive 0 points.**
## 範例
```
Welcome to the NTOU Marine Education Encyclopedia!

Input the name of fish ("quit" to exit): Milk Fish
Milk Fish (Chanos chanos): average length 40cm, average weight 300g, seawater fish.

Input the name of fish ("quit" to exit): Paramecium
Sorry, we cannot find [Paramecium] in our database.

Input the name of fish ("quit" to exit): Gold Head Cichlid
Gold Head Cichlid (Aulonocara baenschi): average length 15cm, freshwater fish.

Input the name of fish ("quit" to exit): quit

Thank you for using the NTOU Marine Education Encyclopedia!
```
