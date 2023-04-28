// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементами массива.
//[3 7 22 2 78] -> 76

double[] GetRandomArrayDouble(int length)
{
    double[] array = new double[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

double MaxElement(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Write("Задайте количество элементов массива> ");
int length1 = int.Parse(Console.ReadLine()!);
double[] mass1 = GetRandomArrayDouble(length1);
Console.WriteLine(string.Join(" ", mass1));
Console.WriteLine($"MAX = {MaxElement(mass1)}");
Console.WriteLine($"MIN = {MinElement(mass1)}");
Console.WriteLine($"MAX-MIN = {MaxElement(mass1) - MinElement(mass1)}");


