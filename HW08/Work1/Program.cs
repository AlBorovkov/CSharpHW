// Задача 54: 
// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Main()
{
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine()!);

    int[,] array = GetArray(rows, columns);
    GetArray(rows, columns);
    PrintArray(array);
    SortArray(array);
    Console.WriteLine();
    PrintArray(array);
}
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 100);
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
void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int count = 0; count < arr.GetLength(1); count++)
        {
            int temp = 0;
            for (int j = 1; j < arr.GetLength(1) - count; j++)
            {
                if (arr[i, j - 1] < arr[i, j])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j - 1];
                    arr[i, j - 1] = temp;
                }
            }
        }
    }
}
Main();