// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число M: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число N: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Сумма натуральных чисел в промежутке от M и N = {SumOfNumbers(m, n)}");
}

int SumOfNumbers(int m, int n)
{
    if (m > n) return 0;
    else return m + SumOfNumbers(m + 1, n);
}

Main();