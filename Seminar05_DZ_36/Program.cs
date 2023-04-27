// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}

int SumElementsOddPos(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0) sumOdd += 0;
        else sumOdd += array[i];
    }
    return sumOdd;
}

Console.Write("Задайте количество элементов массива> ");
int length1 = int.Parse(Console.ReadLine()!);
int[] mass1 = GetRandomArray(length1);
Console.WriteLine(string.Join(" ", mass1));
Console.WriteLine(SumElementsOddPos(mass1));


