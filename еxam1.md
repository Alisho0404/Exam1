# Exam 

### Task 1    
Given a array sorted in non-decreasing order of the elements in it. Determine how many different elements it has. 

----

Дан массив, упорядоченный по неубыванию элементов в нем. Определите, сколько в нем различных элементов.  

----

Бa мо  массив  аз рӯи тартиби зиедшавии элементҳо дода шудааст. Муайян кунед, ки массив чанд элементи гуногун дорад.
 
**Input**
``` 
6
1 2 2 3 3 3
```
**Output**
```
3
```

### Task 2 
Given a array of numbers and the index of an element in the array k. Remove the element at index k       
from the array by shifting all elements to the right of the element at index k to the left.    

----

Дан массив из чисел и индекс элемента в массиве k. Удалите из массив элемент с индексом k,        
сдвинув влево все элементы, стоящие правее элемента с индексом k.  

----

Ба мо массиви ададҳо ва индекси элемент k дода мешавад. 

Элементро дар индекси k аст чоп накунед, ва бокимондаи массивро чоп кунед.
 
**Input**
```
7
7 6 5 4 3 2 1
2
```
**Output**
```
7 6 4 3 2 1
```

### Task 3 
Given an array of size N. Print all elements located between its minimum and maximum elements, including the minimum and maximum elements.    

----
 
Дан массив размером N. Выведите все элементы, расположенные между его минимальным и максимальным элементами, включая минимальный и максимальный элементы.    

----
 
Бо назардошти массиви андозааш N. Ҳама элементҳои дар байни элементҳои минималӣ ва максимали ҷойгиршуда, аз ҷумла элементҳои минималӣ ва максималиро чоп кунед.     

**Input**
```
5
2 1 4 5 2
```
**Output**
```
1 4 5
```

### Task 4 
Given N and an array with size of N. Change all positive elements to 0.

----

Данo N и массив размером N. Измените все положительные элементы на 0.

----

Массиви андозааш N дода мешавад. Ҳама элементҳои мусбатро ба 0 тағир диҳед.

**Input:**
```
5
3 -1  6  -4  9    
```
**Output:**
```
0  -1  0  -4  0
```
**Input:**
```
5
3 -1  6  -4  9
```
**Output:**
```
0 -1 0 -4 0
```

### Task 5 
 You are given an array of integers of size N. Write a program that determines how many times a given number B occurs in a given array.

----

Вам дан массив целых чисел размера N. Напишите программу, которая определяет, сколько раз данное число B встречается в данном массиве.

----

Ба шумо массиви ададҳои бутуни андозааш N дода мешавад. Программае нависед, ки муайян мекунад, ки адади додашудаи B дар массиви додашуда чанд маротиба ёфт мешавад (во мехурад ё чанд маротиба такрор шудаги аст).

**Input**
```
5
1  3  4  5  3
3
```
**Output**
```
2
```
**Input**
```
7
5 -1  2 -1 -1 9 -1
-1
```
**Output** 
```
4
```

### Task 6
 Write a method **void Fibonacci(int n)** to display the n number Fibonacci sequence.     

----
 
Напишите метод **void Fibonacci(int n)** для отображения последовательности чисел Фибоначчи n.    

----
 
 Методи **void Fibonacci(int n)** нависед ки аз аввали раками фибоначи то ба n рақами фибоначиро чоп кунад.

**Input**
```
 5
```
**Output**
```
0 1 1 2 3
```
### Task 7 
Create a method **int SumOfDigits(int n)** to calculate the sum of the individual digits of a given.  

----
 
Cоздать метод **int SumOfDigits(int n)** для вычисления суммы отдельных цифр заданного числа.  

----
 
Методи **int SumOfDigits(int n)** созед, ки суммаи рақамҳои aдади додашударо баргардонад.  
 
**Input**
```
1234
```
**Output**
```
The sum of the digits of the number 1234 is : 10
```

### Task 8

Write a method **void Swap(ref int a, ref int b)** that will take two parameters by reference and swap their values.  

----

Напишите метод **void Swap(ref int a, ref int b)**, который будет принимать два параметра по ссылке и менять их значения местами.  

----

Meтоди **void Swap(ref int a, ref int b)** нависед, ки ду параметр бо ссылка мегирад ва кимматои онҳоро иваз мекунад.  

**Input**
```
x = 5
y = 10
```
**Output**
```
x = 10
y = 5
```

### Task 9 
Write a method **void IncrementArrayElements(ref int[] arr, ref int n)** that will accept an array of type int[] and a value of type int by reference. The method must increment all array elements by the passed value.   

----

Напишите метод **void IncrementArrayElements(ref int[] arr, ref int n)**, который будет принимать массив типа int[] и значение типа int по ссылке. Метод должен увеличивать все элементы массива на переданное значение.  

----

Методи **void IncrementArrayElements(ref int[] arr, ref int n)** нависед, ки массиви навъи int[] ва арзиши навъи int-ро бо ссылки қабул кунад. Метод бояд ҳамаи элементҳои массивро бо арзиши додашуда зиёд кунад.    

**Input**
```
5
1 2 3 4 5
5
```
**Output**
```
 [6, 7, 8, 9, 10] 
```

### Task 10
Write a program to print even or odd numbers in a given range using recursion.  

----

Напишите программу для печати четных или нечетных чисел в заданном диапазоне с использованием рекурсии.  

----

Барои чоп кардани рақамҳои ҷуфт ё тоқ дар диапазони додашуда бо истифода аз рекурсия. 

**Input**
```
 1  20
```
**Output:**

```
2 4 6 8 10 12 14 16 18 20

1 3 5 7 9 11 13 15 17 19
```