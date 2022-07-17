// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



// Console.Clear();

// double[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*(maxValue-minValue);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]:f2} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double[,] array = GetArray(rows, columns, min, max);
// PrintArray(array);
// Console.WriteLine("----------------------- ");
// Console.WriteLine($"row = {rows} ");
// Console.WriteLine($"columns = {columns} ");



//////////////// из семинара сноска для меня
//////////////// array[row, column] = new Random().NextDouble()*(max-min)
/////////////// Console.Write($"{inArray[i,j]:f1} ")





    




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите любое число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int n = 0;
// int[,] array = GetArray(rows, columns, min, max);
// PrintArray(array);
// Console.WriteLine("----------------------- ");
// for (int i = 0; i < rows; i = i + 1)
//     {
//         for (int j = 0; j < columns; j = j + 1)
// {
//    if (array[i,j] == N)
//    {
//     n++;
//    }

// }
// }
//     if (n > 0)
//     {
//         Console.WriteLine($"{N} ");
//     }
//     else
//     Console.WriteLine($"Числа {N} нет ");
    
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// double[] OneArray(int n, int minValue, int maxValue)
// {
//     double[] result = new double [n];
//     for (int i = 0; i < n; i++)
//     {
        
//             result[i] = new Random().Next(minValue, maxValue + 1);
        
//     }
//     return result;
// }
// void PrintArrayOne(double[] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
        
        
//             Console.Write($"{inArray[i]} ");
        
//         Console.WriteLine();
//     }
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double sum = 0;
// int[,] array = GetArray(rows, columns, min, max);
// double [] arrayone = OneArray (columns, min, max);
// PrintArray(array);
// Console.WriteLine("----------------------- ");
// for (int j = 0; j < columns; j = j + 1)
//     {
//         for (int i = 0; i < rows; i = i + 1)
// {
//  sum = array[i,j] + sum;
// arrayone[j] = sum / columns;
// }
// sum = 0;
// }
//     PrintArrayOne(arrayone);
