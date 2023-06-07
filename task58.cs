// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int a, int b)
{
    int[,] Matrix = new int[a,b];
    for (int i=0; i<a; i++)
    {
        for (int j=0; j<b; j++)
        {
            Matrix[i,j] = new Random().Next(0,11);
            Console.Write(Matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return Matrix;
}

void MultiplicateMatrix (int[,] M1, int[,] M2)
{
    
    int[,] MultiMatrix = new int[M1.GetLength(0), M2.GetLength(1)];
    Console.WriteLine($"MultiMatrix строк {M1.GetLength(0)}, количество столбцов {M2.GetLength(1)}");
    for (int k=0; k<MultiMatrix.GetLength(0); k++)
    {
        for (int l=0; l<MultiMatrix.GetLength(1); l++)
        {
            for (int r=0; r<M1.GetLength(1); r++)
            {
                MultiMatrix[k,l] = MultiMatrix[k,l] + (M1[k,r]*M2[r,l]);
            }
            Console.Write(MultiMatrix[k,l] + " ");
            
        }
        Console.WriteLine();
    }
    
}

Console.WriteLine("Программа нахождения произведения двух матриц");
Console.WriteLine("Прежде чем задать размеры матриц, напомню, что перемножить можно только те, для которых верно:");
Console.WriteLine("количество столбцов матрицы1 = количеству строк матрицы2!");
Console.WriteLine();

Console.WriteLine("Введите количество строк для матрицы 1");
int Matrix1a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для матрицы 1");
int Matrix1b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк для матрицы 2");
int Matrix2a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для матрицы 2");
int Matrix2b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] Matrix1 = CreateMatrix(Matrix1a, Matrix1b);
Console.WriteLine();
int[,] Matrix2 = CreateMatrix(Matrix2a, Matrix2b);
Console.WriteLine();

if (Matrix1b != Matrix2a)
    Console.WriteLine("Такие матрицы нельзя перемножить!");
else MultiplicateMatrix(Matrix1, Matrix2);
