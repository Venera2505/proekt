// // Console.WriteLine("Введите целое число");
// // int num = Convert.ToInt32( Console.ReadLine()) ;
// // int result = num * num;
// // Console.WriteLine(result);

// // if (num>0)
// // {
// // Console.WriteLine("Было введено положительное число");
// // }
// // else if (num==0)
// // Console.WriteLine("Был введен ноль");
// // else
// // Console.WriteLine("Было введено отрицательное число");
// //====================================================================
// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3


// // Console.WriteLine("Введите первое число");
// // int num1 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите второе число");
// // int num2 = Convert.ToInt32(Console.ReadLine());
// // int min = 0;
// // int max = 0;
// // if (num1 > num2)
// // {
// //     max = num1;
// //     min = num2;
// //     Console.WriteLine(num1 + " - максимальное число");
// //     Console.WriteLine(num2 + " - минимальное число");
// // }
// // else if(num2 > num1)
// // {
// // max = num2;
// // min = num1;
// //     Console.WriteLine(num2 + " - максимальное число");
// //     Console.WriteLine(num1 + " - минимальное число");
// // }
// //===============================================================================
// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22


// // Console.WriteLine("Введите первое число");
// // int num1 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите второе число");
// // int num2 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите третье число");
// // int num3 = Convert.ToInt32(Console.ReadLine());

// // int max = num1;

// // if (num2 > max) 
// // {
// //     max = num2;
// // }
// // if (num3 > max) 
// // {
// //     max = num3;
// //     Console.WriteLine(max);
// // }    


// //=======================================================================
// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// // Console.WriteLine("Введите число");
// // int num = Convert.ToInt32(Console.ReadLine());
// // int result = num % 2;

// // if (result == 0)
// // {
// //     Console.WriteLine(" - четное число");
// // }
// // else 
// // Console.WriteLine(" - нечетное число");

// //================================================================
// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = 2;
// if (num > 1)
// {
//     while (result <= num)
// {
//     Console.WriteLine(result);
//     result = result + 2;
// }
// }


// Программа которая выводит случайное число и показыыает наибольшую цифру;

// int num = new Random().Next(10,100);
// Console.WriteLine($"Было сгенерировано число {num}");
// // Console.WriteLine("Было сгенерировано число" +num);
// int num1 = num/10;
// int num2 = num % 10;
// if (num1>num2)
//     Console.WriteLine($"Наибольшая цифра{num1}");
// else if (num<num2)
//     Console.WriteLine($"Наибольшая цифра это{num2}");
//  else
//     Console.WriteLine("Обе цифры числа равны");   

// for (int i=1; i<=num; i=i+3)
//     Console.WriteLine($"{i} ");


// выводит 3х значные числа и удаляет вторую цифру

// int num = new Random().Next(100,999);
// Console.WriteLine($"Было сгенерировано число {num}");
// int num1 = num/100;
// int num2 = num % 10;
// Console.Write(num1);
// Console.Write(num2);


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.WriteLine("Введите 1 число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1%num2 == 0)
// {
//     Console.WriteLine("кратно");
// }
// else if (num1%num2 !=0)
// {
//     Console.WriteLine("не кратно " + num1%num2);
// }


// напищите программу которая принимает одновременно 2 числа и проверяет является ли 1 чтсло квадратом другого
// 5,25

// Console.WriteLine("Введите 1 число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 * num1 == num2)
// {
//     Console.WriteLine("явлется квадратом");
// }
// else if (num1 * num1 != num2)  
// {
//     Console.WriteLine("не квадрат");
// }



// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.



// Console.WriteLine("Введите число");
//  int num = Convert.ToInt32(Console.ReadLine());
//  if (num % 7 == 0 & num % 23 == 0)
//     Console.WriteLine("является кратным 7 и 23");
// else 
//    Console.WriteLine("не является кратным");



// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("введите число");
// string? num = Console.ReadLine();

// void CheckPalindrome(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3])
//   {
//     Console.WriteLine(number + " палиндром");
//   }
//   else Console.WriteLine(number + " не палиндром");
// }

// if (num!.Length == 5)
// {
//   CheckPalindrome(num);
// }

            
            
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int a1 = Coordinate("a", "A");
// int b1 = Coordinate("b", "A");
// int c1 = Coordinate("c", "A");
// int a2 = Coordinate("a", "B");
// int b2 = Coordinate("b", "B");
// int c2 = Coordinate("c", "B");

// int Coordinate(string coordinate, string point)
// {
//     Console.Write("Введите координату " + coordinate + " точки " + point);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Decision(double a1, double a2, 
//                 double b1, double b2, 
//                 double c1, double c2)
//                 {
//   return Math.Sqrt(Math.Pow((a2-a1), 2) + 
//                    Math.Pow((b2-b1), 2) + 
//                    Math.Pow((c2-c1), 2));
// }

// double length =  Math.Round (Decision(a1, a2, b1, b2, c1, c2), 2 );

// Console.WriteLine("Длина отрезка " + length);



//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void cubeNum(int[] cube)
// {
//   int count = 0;
//   int length = cube.Length;
//   while (count <  length){
//     cube[count] = Convert.ToInt32(Math.Pow(count, 3));
//     count++;
//   }
// }

// void PrintArray(int[] coll)
// {
//   int counter = coll.Length;
//   int index = 1;
//   while(index < counter){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] array = new int[cube+1];
// cubeNum(array);
// PrintArray(array);





// 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1



// Console.WriteLine("Введите 3х значное число");
// int num = Convert.ToInt32(Console.ReadLine());
// void numOfArray(int [] number)
// {
//   Console.WriteLine(n);
// }
// numOfArray{2,3,4};

