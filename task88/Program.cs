// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



void FillArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++) 
        for(int j=0; j<array.GetLength(1); j++) 
            array[i,j] = new Random().Next(-30,30);
}
void PrintArray(int[,] array)
{
        for(int i=0; i<array.GetLength(0); i++) 
            {
            for(int j=0; j<array.GetLength(1); j++) 
            System.Console.Write($"{array[i,j],3}    ");
            System.Console.WriteLine();
            }
}



void OrderLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}



System.Console.WriteLine("Введите количество строк");
 int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
 int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
OrderLines(array);
Console.WriteLine($"\n Mассив после сортировки: ");
PrintArray(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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



// int SumLine(int[,] array, int i)
// {
//   int sum = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sum += array[i,j];
//   }
//   return sum;
// }

// void FindMinSumLine(int[,] array)
// {
// int minSum = 0;
// int sumLine = SumLine(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLine(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSum = i;
//   }
// }
// Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой ({sumLine}) ");
// }


// System.Console.WriteLine("Введите количество строк");
//  int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
//  int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// SumLine(array,0);
// FindMinSumLine(array);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



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


// void FindFinalMatrix(int[,] firstArray, int[,] secArray, int[,] resultArray)
// {
//   for (int i = 0; i < resultArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultArray.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstArray.GetLength(1); k++)
//       {
//         sum += firstArray[i,k] * secArray[k,j];
//       }
//       resultArray[i,j] = sum;
//     }
//   }
// }

// System.Console.WriteLine("Введите количество строк в матрице 1");
//  int rowsFirstMatx = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов в мвтрице 1");
//  int colsFirstMatx = Convert.ToInt32(Console.ReadLine());
// int[,] firstArray = new int[rowsFirstMatx, colsFirstMatx];
// FillArray(firstArray);
// PrintArray(firstArray);
// System.Console.WriteLine("Введите количество строк в матрице 2");
//  int rowsSecMatx = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов в мaтрице 2");
//  int colsSecMatx = Convert.ToInt32(Console.ReadLine());
// int[,] secArray = new int[rowsFirstMatx, colsFirstMatx];
// int[,] resultArray = new int[rowsFirstMatx,colsSecMatx];
// FillArray(secArray);
// PrintArray(secArray);
// FindFinalMatrix(firstArray, secArray, resultArray);
// Console.WriteLine($"\n Произведение  двух матриц:");
// PrintArray(resultArray);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// void FillArray(int[,,] array)
// {
//   int[] result = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//   int  num = 0;;
//   for (int i = 0; i < result.GetLength(0); i++)
//   {
//     result[i] = new Random().Next(10, 100);
//     num = result[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (result[i] == result[j])
//         {
//           result[i] = new Random().Next(10, 100);
//           j = 0;
//           num = result[i];
//         }
//           num = result[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array.GetLength(0); x++)
//   {
//     for (int y = 0; y < array.GetLength(1); y++)
//     {
//       for (int z = 0; z < array.GetLength(2); z++)
//       {
//         array[x, y, z] = result[count];
//         count++;
//       }
//     }
//   }
// }

// void PrintArray(int[,,] array)
// {
//         for(int i=0; i<array.GetLength(0); i++) 
//             {
//             System.Console.WriteLine();
//             System.Console.WriteLine("Страница №: " + (i + 1));
//             System.Console.WriteLine();

//             for(int j=0; j<array.GetLength(1); j++) 
//                 {
//                     for (int k = 0; k < array.GetLength(2); k++)
//                     {    
//             System.Console.Write($"{array[i,j,k],3 }" + "(" + i + "," + j + "," + k +")");
//             }
//             System.Console.WriteLine();
//          }
//      }    
// }



// System.Console.WriteLine("Введите количество страниц");
//  int pages = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество строк");
//  int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество колонок");
//  int cols = Convert.ToInt32(Console.ReadLine());
// int[,,] array = new int[pages, rows, cols];
// FillArray(array);
// PrintArray(array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// void FillArray(int[,] spiralArray)
// {
//     int temp = 1;
//     for(int i=0; i<spiralArray.GetLength(0); i++) 
//     {
//         for(int j=00; j<spiralArray.GetLength(1); j++) 
//             {
//                 while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
// {
//   spiralArray[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
//   {
//     j++;
//   }
//   else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
//   {
//     i++;
//   }
//   else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
//   {
//     j--;
//   }
//   else
//     i--;
//           }
//        }
//     }            
// }
// void PrintSpiralArray(int[,] spiralArray)
// {
//         for(int i=0; i<spiralArray.GetLength(0); i++) 
//             {
//             for(int j=0; j<spiralArray.GetLength(1); j++) 
//             {

//             System.Console.Write($"{spiralArray[i,j],3}    ");
            
//             }
//                 System.Console.WriteLine();
//      }
// }

// System.Console.WriteLine("Введите количество строк");
//  int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
//  int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintSpiralArray(array);

