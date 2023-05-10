// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] EnterFigures(int length1)
{
    int i = 0;
    int[] fig = new int[length1];
    for (i = 0; i < length1; i++)
    {
        Console.Write("Введите число> ");
        fig[i] = Int32.Parse(Console.ReadLine()!);
    }
    return fig;
}

int QuantityPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Задайте количество чисел М> ");
int length = int.Parse(Console.ReadLine()!);
int[] mass = EnterFigures(length);

Console.WriteLine(string.Join(" ", mass));
Console.WriteLine($"Количество положительных чисел > {QuantityPositive(mass)}");



