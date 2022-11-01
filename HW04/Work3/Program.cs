// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

void Main()
{
    Console.Clear();
    int size = 8;
    int[] array = new int[size];
    FillArray(array, size);
    PrintArray(array);
}

void FillArray(int[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        int a = new Random().Next(0, 100);
        arr[i] = a;
    }
}

void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(',', arr) + "]");
}

Main();