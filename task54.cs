// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void PrintArray(int[,] array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ReverseSortArray (int[,] array)
{
    int[,] SortArray2d = new int[array.GetLength(0),array.GetLength(1)];
    int[] TempArray =   new int[array.GetLength(1)];
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            TempArray[j] = array[i,j];
        }
        Array.Sort(TempArray);
        Array.Reverse(TempArray);
        for (int j=0; j<array.GetLength(1); j++)
        {
            SortArray2d[i,j] = TempArray[j];
        }
    }
    return SortArray2d;
}

Console.WriteLine("Программа упорядочивания элементов двумерного массива по убыванию");
Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов в строке (количество столбцов) в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m,n];
for (int i=0; i<array2d.GetLength(0); i++)
{
    for (int j=0; j<array2d.GetLength(1); j++)
    {
        array2d[i,j] = new Random().Next(0,11);
        Console.Write(array2d[i,j] + " ");
    }
    Console.WriteLine();
}
int[,] SortArray2d = new int[m,n];
SortArray2d = ReverseSortArray(array2d);
Console.WriteLine();
PrintArray(SortArray2d);