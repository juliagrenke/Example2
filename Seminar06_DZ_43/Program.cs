// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PeresechOfLine(double k1, double b1, double k2, double b2)
{
    {
        double x = 0;
        double y = 0;
        if (k1 == k2 && b1 == b2)
            Console.WriteLine("Линии параллельны или совпадают, пересечения нет");
        else
        {
            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;
            Console.WriteLine($" ({x} , {y})");
        }
    }
}

Console.Write("Задайте коэффициент k1 > ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Задайте коэффициент b1 > ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Задайте коэффициент k2 > ");
int k2 = int.Parse(Console.ReadLine()!);
Console.Write("Задайте коэффициент b2 > ");
int b2 = int.Parse(Console.ReadLine()!);
PeresechOfLine(k1, b1, k2, b2);



