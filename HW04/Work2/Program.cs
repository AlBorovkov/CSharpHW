// Задача 27: 
// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void Main()
{
    Console.Clear();
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine(GetSum(num));
}

int GetSum(int num)
{
    int sum = 0;
    if (num < 0)
    {
        num = -num;
    }
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
Main();
