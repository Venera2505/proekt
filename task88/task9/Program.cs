﻿//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string AllNumbers(int num)
// {
//     if (num==1) return $"{1}";
//     return $"{num}, " + $"{AllNumbers(num-1)}";

// }


// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(AllNumbers(num));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumOfAllNumbers(int num, int num2)
// { 
    
    
//     if (num2==num) return num2;
//     return SumOfAllNumbers(num, num2-1) + num2;

// }
// System.Console.WriteLine("Введите целое число M: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите целое число N: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SumOfAllNumbers(num, num2));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FindFunctionsAkkn(int num, int num2)
{ 
    
    
    if (num==0) return num2 + 1;
        if (num > 0 && num2 == 0 ) return FindFunctionsAkkn(num-1, 1);
             return FindFunctionsAkkn(num-1, FindFunctionsAkkn(num,num2-1));
    }


System.Console.WriteLine("Введите целое число M: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindFunctionsAkkn(num, num2));