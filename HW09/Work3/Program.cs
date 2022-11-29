// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число M: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число N: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Функция Аккермана = {AkkermanFun(m, n)}");
}

int AkkermanFun(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFun(m - 1, 1);
    else return AkkermanFun(m - 1, AkkermanFun(m, n - 1));
}

Main();