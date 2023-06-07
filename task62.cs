// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Программа заполнения двумерного массива по спирали");
Console.WriteLine("Введите количество строк ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Matrix = new int[N,M];
int Ibeg = 0;
int Ifin = 0;
int Jbeg = 0;
int Jfin = 0;
    
int k = 1;
int i = 0;
int j = 0;

while (k <= N * M)
{
    Matrix[i,j] = k;
    if (i == Ibeg && j < M - Jfin - 1)
        ++j;
    else if (j == M - Jfin - 1 && i < N - Ifin - 1)
        ++i;
    else if (i == N - Ifin - 1 && j > Jbeg)
        --j;
    else
        --i;

    if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1))
    {
        ++Ibeg;
        ++Ifin;
        ++Jbeg;
        ++Jfin;
    }
        ++k;
}
    
for (int p = 0; p < N; p++)
{
    for (int r = 0; r < M; r++)
       Console.Write(Matrix[p,r] + " ");
       Console.WriteLine();
}

    