﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void FillArray(double[,] array)

// {
//     for(int i=0; i<array.GetLength(0); i++) 
//     {
//         for(int j=0; j<array.GetLength(1); j++) 
//         {
//             Random rand = new Random();
//             array[i,j] = Math.Round(rand.Next(0,100) + rand.NextDouble(), 2);
//         }
//     }
// }
// void PrintArray(double[,] array)
// {
//         for(int i=0; i<array.GetLength(0); i++) 
//             {
//             for(int j=0; j<array.GetLength(1); j++) 
//             System.Console.Write($"{array[i,j],3}    ");
//             System.Console.WriteLine();
//             }
// }

// System.Console.WriteLine("Введите количество строк");
//  int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
//  int cols = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[rows, cols];
// FillArray(array);
// PrintArray(array);

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// void FindPosition(int[,] element, int num)
//     {
//         bool find = false;
//             for(int i=0; i<element.GetLength(0); i++) 
//     {
//         for(int j=0; j<element.GetLength(1); j++) 
//         {
//         if (element[i,j] == num)
//           Console.WriteLine("Значение элемента расположено по координатам " + i + ", " + j);
//           find = true;
//         }
//         if (!find) 
//              System.Console.WriteLine("Такого элемента нет");   
// }
//     }


// void FillArray(int[,] array)
// {
//     for(int i=0; i<array.GetLength(0); i++) 
//         for(int j=0; j<array.GetLength(1); j++) 
//             array[i,j] = new Random().Next(0,10);
// }
// void PrintArray(int[,] array)
// {
//         for(int i=0; i<array.GetLength(0); i++) 
//             {
//             for(int j=0; j<array.GetLength(1); j++) 
//             System.Console.Write($"{array[i,j],3}    ");
//             System.Console.WriteLine();
//             }
// }



// System.Console.WriteLine("Введите количество строк");
//  int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
//  int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine("Введите значение элемента:");
// int number = Convert.ToInt32(Console.ReadLine());
// FindPosition(array, number);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// void FillArray(int[,] array)
// {
//     for(int i=0; i<array.GetLength(0); i++) 
//         for(int j=0; j<array.GetLength(1); j++) 
//             array[i,j] = new Random().Next(0,30);
// }
// void PrintArray(int[,] array)
// {
//         for(int i=0; i<array.GetLength(0); i++) 
//             {
//             for(int j=0; j<array.GetLength(1); j++) 
//             System.Console.Write($"{array[i,j],3}    ");
//             System.Console.WriteLine();
//             }
// }
// void FindAvg(int[,] array)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         avarage = (avarage + array[i, j]);
//     }
//     avarage = avarage / array.GetLength(0);
//     System.Console.WriteLine(avarage + "; ");
//     }
// }
// System.Console.WriteLine("Введите количество строк");
//  int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
//  int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// FindAvg(array);