﻿// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Main()
{
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine()!);

    int[,] array = GetArray(rows, columns);
    GetArray(rows, columns);
    PrintArray(array);
    PrintArithmeticMean(array);
}
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void PrintArithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        sum = Math.Round(sum / array.GetLength(0), 1);
        Console.WriteLine($"Среднее арифметическое столбца №{i + 1} таблицы равняется {sum}");
    }
}
Main();