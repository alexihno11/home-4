// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("vvedite razmer massiva:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// ZapolniteMassivRandomNumbers(numbers);
// Console.WriteLine("massiv: ");
// PrintArray(numbers);
// int count = 0;

// for (int s = 0; s < numbers.Length; s++)
// if (numbers[s] % 2 == 0)
// count++;

// Console.WriteLine($"vsego {numbers.Length} chisel, {count} из них чётные");

// void ZapolniteMassivRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] ArrayNumbers = new int[4];
int summ = 0;
  for (int i = 1; i < ArrayNumbers.Length; i+=2 )
  {
    ArrayNumbers[i] = new Random().Next(1, 4);
summ = ArrayNumbers + summ;
    
  }
Console.Write(ArrayNumbers[i] + summ " ");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] ArrayNumbers = new double[7];
//   for (int i = 0; i < ArrayNumbers.Length; i++ )
//   {
//     ArrayNumbers[i] = new Random().Next(1, 7);
//     Console.Write(ArrayNumbers[i] + " ");
//   }
// double maxNumber = ArrayNumbers[0];
// double minNumber = ArrayNumbers[0];

//   for (int i = 1; i < ArrayNumbers.Length; i++)
//   {
//     if (maxNumber < ArrayNumbers[i])
//     {
//       maxNumber = ArrayNumbers[i];
//     }
//         if (minNumber > ArrayNumbers[i])
//     {
//       minNumber = ArrayNumbers[i];
//     }
//   }
//   double advance = maxNumber - minNumber;
//   Console.WriteLine($"\nразница между между макс. ({maxNumber}) и мин/({minNumber}) элементами: {advance}");
