/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


int SumNumberOfDiapasone(int m, int n)
{
    if (n == m) return n;
    int sum = m;
    {
        sum = m + SumNumberOfDiapasone(m + 1, n);
    }
    return sum;
}

Console.Write("Задайте m: ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write("Задайте n: ");
int n = Int32.Parse(Console.ReadLine()!);
Console.WriteLine($"{SumNumberOfDiapasone(m, n)}");