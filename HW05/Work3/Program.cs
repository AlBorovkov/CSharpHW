// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] newArray)
{
    Console.Write("Массив: ");
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(-99, 100);
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();

    double max = newArray[0];
    double min = newArray[0];
    for (int i = 0; i < newArray.Length; i++)
    {
        if(newArray[i] > max) max = newArray[i];
        if(newArray[i] < min) min = newArray[i];
    }
    Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива равна {max - min}");
}

double[] array = new double[10];
FillArray(array);