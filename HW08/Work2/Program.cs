// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

void Main()
{
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine()!);

    int[,] array = GetArray(rows, columns);
    GetArray(rows, columns);
    PrintArray(array);
    MinSumRowArray(array);
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
void MinSumRowArray(int[,] arr)
{
    int minSumm = 0;
    int summ = 0;
    int numMinRow = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i, j];
        }      
        if (i == 0)
        {
            minSumm = summ;
        }
        else if (summ < minSumm)
        {
            minSumm = summ;
            numMinRow = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов = {numMinRow + 1}");
}
Main();