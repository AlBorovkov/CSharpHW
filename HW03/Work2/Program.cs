// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату A(x): ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату A(y): ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату A(z): ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату B(x): ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату B(y): ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату B(z): ");
int z2 = int.Parse(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)),2);
Console.WriteLine ($"Расстояние между точкой A и точкой B равно {distance}");