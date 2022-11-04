// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
    Console.Clear();
    int size = 8;
    int[] array = FillArray(size);
    PrintArray(array);
    EvenNumbers(array);
}
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(',', arr) + "]");
}
void EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел в массиве равно {count}");
}
Main();