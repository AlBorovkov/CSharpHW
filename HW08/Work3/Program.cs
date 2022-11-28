// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Main()
{
    Console.Clear();
    int[,] array1 = new int[2, 2];
    FillArray(array1);

    int[,] array2 = new int[2, 2];
    FillArray(array2);
    Console.WriteLine("Первая матрица: ");
    PrintArray(array1);
    Console.WriteLine("Вторая матрица: ");
    PrintArray(array2);
    Console.WriteLine("Произведение двух матриц: ");
    MultiplyArrays(array1, array2);
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 9);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplyArrays(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    result[i, j] += (arr1[i, k] * arr2[k, j]);
                }
            }
        }
        PrintArray(result);
    }
}

Main();