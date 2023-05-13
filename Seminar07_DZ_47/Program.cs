// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] GetDoubleArray(int rows, int cols, double minValue = -10, double maxValue = 10)
{
    double[,] array = new double[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array;
}

void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк массива > ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива > ");
int n = Int32.Parse(Console.ReadLine()!);
double[,] array = GetDoubleArray(m, n);
PrintDoubleArray(array);