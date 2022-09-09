
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// int a = InputNumbers("Введите число строк 1-ой матрицы: ");
// int b = InputNumbers("Введите число столбцов 1-ой матрицы и строк 2-ой: ");
// int c = InputNumbers("Введите число столбцов 2-ой матрицы: ");
// int random = InputNumbers("Введите диапазон случайных чисел: от 1 до 5");

// int[,] firstMatrix = new int[a, b];
// GetArray(firstMatrix);
// Console.WriteLine($"\nПервая матрица:");
// WriteArray(firstMatrix);

// int[,] secondMatrix = new int[b, c];
// GetArray(secondMatrix);
// Console.WriteLine($"\nВторая матрица:");
// WriteArray(secondMatrix);

// int[,] resultMatrix = new int[a,c];

// UmnozhenayaMatrix(firstMatrix, secondMatrix, resultMatrix);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void UmnozhenayaMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMatrix[i,k] * secondMatrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void GetArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1,5);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// int a = InputNumbers("Введите a: ");
// int b = InputNumbers("Введите b: ");
// int diapazon = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[a, b];
// GetArray(array);
// WriteArray(array);

// int minimalSumElem = 0;
// int sumElemLine = SumAllLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumElem = SumAllLineElements(array, i);
//   if (sumElemLine > tempSumElem)
//   {
//     sumElemLine = tempSumElem;
//     minimalSumElem = i;
//   }
// }

// Console.WriteLine($"\n{minimalSumElem+1} - строкa с наименьшей суммой ({sumElemLine}) элементов ");


// int SumAllLineElements(int[,] array, int i)
// {
//   int sumElemLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumElemLine += array[i,j];
//   }
//   return sumElemLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void GetArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(diapazon);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7

// int n = 4;
// int[,] squareMatrix = new int[n, n];

// int shag = 1;
// int i = 0;
// int j = 0;

// while (shag <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
// {
//   squareMatrix[i, j] = shag;
//   shag++;
//   if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)j++;
//   else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)i++;
//   else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)j--;
//   else i--;
// }

// WriteArray(squareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumVPromezhutke(m, n);

// void SumVPromezhutke(int m, int n)
// {
//     Console.Write(SummaMN(m - 1, n));
// }

// int SummaMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SummaMN(m, n);
//         return res;
//     }
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);

// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

