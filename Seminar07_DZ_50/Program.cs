// Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] GetArray(int rows, int cols, int minValue = -100, int maxValue = 100)
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

void PrintArray(int[,] array)
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

void SearchElementMatrix(int[,] array, int i1, int j1)
{
    if (i1 < array.GetLength(0)+1 && j1 < array.GetLength(1)+1)
    {
        Console.WriteLine($"Искомое число {array[(i1-1), (j1-1)]}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

int[,] array = GetArray(5, 6);
PrintArray(array);
Console.Write("Введите строку (i)> ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите столбец (j)> ");
int n = Int32.Parse(Console.ReadLine()!);
SearchElementMatrix(array, m, n);