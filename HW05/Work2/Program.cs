// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Main()
{
    Console.Clear();
    int size = 4;
    int[] array = FillArray(size);
    PrintArray(array);
    EvenNumbers(array);
}
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(',', arr) + "]");
}
void EvenNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
}
Main();