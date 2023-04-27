// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int EvenNumberQuantity(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 > 0) n += 0;
        else n += 1;
    }
    return n;
}

Console.Write("Задайте количество элементов массива> ");
int length1 = int.Parse(Console.ReadLine()!);
int[] mass1 = GetRandomArray(length1);
Console.WriteLine(string.Join(" ", mass1));
Console.WriteLine(EvenNumberQuantity(mass1));


