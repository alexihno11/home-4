// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Write("Введите число A: ");
// Console.Write("Введите число B: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// int secNum = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= secNum; i++)
// {
//   result = result * firstNum;
// }


// return result;


// Console.WriteLine("Ответ: " + firstNu);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
//   int SumNumber(int number)
//   {
    
//     int count = Convert.ToString(number).Length;
//     int raznica = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++)
//     {
//       raznica = number - number % 10;
//       result = result + (number - raznica);
//       number = number / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(number);
// Console.WriteLine("Сумма цифр: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] array = GetBinaryArray(8);
// Console.Write($"[{String.Join(",", array)}]");
// int[] GetBinaryArray(int size)
// {
// int[] result = new int[size];
// // new int[size] - массив размером size элементов
// // заполнен массив "0"
// // result.Length = size
// for (int i = 0; i < result.Length; i++)
// {
// result[i] = new Random().Next(99);// [0;99)
// // (2) - считаем, что числа от 0 до 100 (100 не включается)
// }
// return result; // int [] result
// }