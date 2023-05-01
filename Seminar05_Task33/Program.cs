// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует
// ли заданное число в массиве.
//4; массив [6, 7, 19, 345, -3] -> нет
//-3; массив [6, 7, 19, 345, -3] -> да


int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-999, 999);
    }
    return array;
}

int SelectElement(int number, int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {
            result = array[i];
        }
    }        
    return result;
}

//int Print (int result)
Console.Write("Задайте количество элементов массива> ");
int length1 = int.Parse(Console.ReadLine()!);
int[] mass1 = GetRandomArray(length1);
Console.WriteLine(string.Join(" ", mass1));
Console.Write("Введите число для поиска> ");
int number = int.Parse(Console.ReadLine()!);
int res = SelectElement(number, mass1);
if (res == 0)
{
    Console.WriteLine("No");
}
else Console.WriteLine("Yes");


