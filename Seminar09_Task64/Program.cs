/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

string NatureNumberInDiapasone(int n, int m)
{
    if (n == 1) return $"{n} ";
    {
        return n + ", " + NatureNumberInDiapasone(n - 1, m) ;
    }
}

Console.Write("Задайте число больше 1 : ");
int n = Int32.Parse(Console.ReadLine()!);
Console.WriteLine(NatureNumberInDiapasone(n, 1));