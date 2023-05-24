/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

void PrintMatrix(int[,,] mass3d)
{
    for (int i = 0; i < mass3d.GetLength(0); i++)
    {
        for (int j = 0; j < mass3d.GetLength(1); j++)
        {
            Console.Write("| ");
            for (int k = 0; k < mass3d.GetLength(2); k++)
            {
                Console.Write($"{mass3d[i, j, k],1}({i}, {j}, {k}) | ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] GetArray(int rows, int cols, int depth)
{
    int[,,] array = new int[rows, cols, depth];

    //var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array[i, j, k] = GenerateUniqueNumber(); 
            }
        }
    }
    return array;
}

List<int> mass = new List<int>();
var res = new Random();
int GenerateUniqueNumber()
{
    {
        while (true)
        {
            var n = res.Next(10, 100);
            if (!mass.Contains(n))
            {
                mass.Add(n);  
                return n;
            }  
        }
    }
}

Console.Write("Введите размерность 3D массива (не более 4) > ");
int dim = Int32.Parse(Console.ReadLine()!);
int[,,] array = GetArray(dim, dim, dim);
PrintMatrix(array);


