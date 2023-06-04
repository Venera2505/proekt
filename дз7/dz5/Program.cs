﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// Console.WriteLine("Введите размер массива");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// int[] num = new int [arraySize];
// int countNum = 0;
// FillArray(num);
// PrintArray(num);
// CountEvenNums(num);


// Console.WriteLine($"В массиве {num.Length} чисел, {countNum} из них чётные");

// int[] FillArray(int[] num)
// {
//     for(int i = 0; i < num.Length; i++)
// {
//     num[i] = new Random().Next(100,1000);
// }
// return num;


// }
// void PrintArray(int[] num)
// {
//     Console.WriteLine("[" + string.Join(", ", num) + "]");
// }

// void CountEvenNums (int[] num)
// {
// for (int i = 0; i < num.Length; i++)
//  if (num[i] % 2 == 0)
//  countNum ++;
// }




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// Console.WriteLine("Введите размер массива");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// int[] num = new int [arraySize];
// int countSum = 0;
// FillArray(num);
// PrintArray(num);
// CountSumOddPos(num);



// int[] FillArray(int[] num)
// {
//     for(int i = 0; i < num.Length; i++)
// {
//     num[i] = new Random().Next(0, 99);
// }
// return num;
// }



// void PrintArray(int[] num)
// {
//     Console.WriteLine("[" + string.Join(", ", num) + "]");
// }

// void CountSumOddPos(int[] num)
// {
// for(int i = 0; i < num.Length; i++)
// if (i % 2 != 0)
// countSum = countSum + num [i];
// }
// Console.WriteLine($"В массиве {num.Length} чисел, {countSum} сумма элементов на нечетных позициях");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите размер массива");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// double[] num = new double [arraySize];
// Random rand = new Random();
// double diff = 0;
// FillArray(num);
// PrintArray(num);
// findDiff(num);


// Console.WriteLine($"В массиве {num.Length} чисел, {diff} разница между макс и мин элементом");

// double[] FillArray(double[] num)
// {
//     for( int i = 0; i < num.Length; i++)
// {
//     num[i] = Math.Round(rand.Next(0,100) + rand.NextDouble(), 3);
// }
// return num;
// }


// void PrintArray(double[] num)
// {
//     Console.WriteLine("[" + string.Join(", ", num) + "]");
// }

// double findDiff(double[] num)
// {

// double max = num[0];
// double min = num[0];
 

//  for (int i = 1; i < num.Length; i++)
//  {

// if (num[i] > max)
// {
//      max = num[i];
// }
 
//  else if (num[i] < min) 
// {
//     min = num[i];
// }
//     diff=max-min;
//  System.Console.WriteLine("The minimum array element is " + min);
//  System.Console.WriteLine("The maximum array element is " + max);
//  System.Console.WriteLine(diff);
// }

// return diff;
// }
 
