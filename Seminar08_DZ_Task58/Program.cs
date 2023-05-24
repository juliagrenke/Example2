/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] GetArray(int rows, int cols, int minValue = 0, int maxValue = 9)
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

int[,] MatrComposition(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return arr3;
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

Console.Write("Введите количество строк мартрицы A> ");
int rows1 = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов мартрицы A> ");
int cols1 = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк мартрицы B> ");
int rows2 = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов мартрицы B> ");
int cols2 = Int32.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows1, cols1);
PrintArrayMatr(array);
int[,] array1 = GetArray(rows2, cols2);
PrintArrayMatr(array1);

if (rows1 == cols2)
{
    int[,] rezarr = MatrComposition(array, array1);
    PrintArrayMatr(rezarr);
}
else
{
    Console.WriteLine($"количество строк матрицы А (вы задали {rows1}) должно быть равно количеству столбцов матрицы В (вы задали {cols2}) Нельзя получить произведение A*B");
}
Console.WriteLine();