// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Main()
{
    Console.Clear();
    Console.Write("Сколько чисел вы хотите ввести? \nОтвет:\t");
    int size = int.Parse(Console.ReadLine()!);
    int[] myArray = new int[size];
    PositiveEl(myArray);

}
void PositiveEl(int[] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        myArray[i] = int.Parse(Console.ReadLine()!);
        if (myArray[i] > 0) count++;
    }
    Console.WriteLine($"Число введенных числе больше нуля = {count}");
}
Main();