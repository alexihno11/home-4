// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine()); // строки
// // матрица - двумерный массив
// // матрица - табличка, которая состоит из m строк и n столбцов
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine()); // столбцы

// /// summary - "///" - комментарий перед методом
// /// Описывает входные и выходные данные метода

// // Комментарий, а summary - только для методов

// /// m - кол-во строк, n - кол-во столбцов
// /// minRandom, maxRandom
// double[,] GetArray(int m, int n, int minRandom, int maxRandom)
// {
// //new int[кол-во строк,кол-во столбцов]
// double[,] matrix = new double[m, n];
// for (int i = 0; i < matrix.GetLength(0); i++) // строчки: GetLength(1) = m (кол-во строк)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)// столбцам: GetLength(1) = n(кол-во столбцов)
// {
// matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;//[)
// }
// }
// return matrix;
// }

// double[,] resultMatrix = GetArray(rows, columns, 0, 10);
// PrintArray(resultMatrix);
// void PrintArray(double[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++) // строчки
// {
// for (int j = 0; j < matrix.GetLength(1); j++)// столбцам: GetLength(1) = n(кол-во столбцов)
// {
// Console.Write(matrix[i, j] + "\t"); // "\t" - Tab между элементами
// }
// Console.WriteLine();
// }
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



// Console.Write("Введите индекс строки: ");
// int rows = Convert.ToInt32(Console.ReadLine()); // строки
// Console.Write("Введите индекс столбца: ");
// int columns = Convert.ToInt32(Console.ReadLine()); // столбцы
// int[,] numbers = new int[4, 6];
// FillArray(numbers);
// PrintArray(numbers);

// if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1)) Console.WriteLine(numbers[rows, columns]);
// else Console.WriteLine($"{rows}{columns} -> числа в массиве нет");

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()); // строки
// матрица - двумерный массив
// матрица - табличка, которая состоит из m строк и n столбцов
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()); // столбцы
int[,] numbers = new int[rows, columns];
FillArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        average = (average + numbers[i, j]);
    }
    average = average / rows;
    Console.Write(average + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}