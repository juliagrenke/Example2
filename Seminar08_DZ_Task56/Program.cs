/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

/*void PrintArrayMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}*/

int[,] GetArray(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

int[] SumElementsOfString(int[,] array)
{
    int[] sumEl = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumEl[i] += array[i, j];
        }
        Console.WriteLine($"Сумма элементов строки {i + 1} > {sumEl[i]}");
    }
    return sumEl;
}

void MinSumOfElementsString(int[] arr)
{
    int summin = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= summin) summin = arr[i];
    }
    int k = Array.IndexOf(arr, summin)+1;
    Console.WriteLine($"Минимальная сумма элементов {summin} в строке {k}");
}

void PrintArrayMatr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = GetArray(6, 5);
PrintArrayMatr(array);
int[] array1 = SumElementsOfString(array);
//PrintArrayMass(array1);
MinSumOfElementsString(array1);
Console.WriteLine();