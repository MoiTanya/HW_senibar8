// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7


Console.WriteLine("Программа нахождения строки двумерного массива с наименьшей суммой элементов");
Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов в строке (количество столбцов) в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array2d = new int[m,n];
int[] summ = new int[array2d.GetLength(0)];
for (int i=0; i<array2d.GetLength(0); i++)
{
    for (int j=0; j<array2d.GetLength(1); j++)
    {
        array2d[i,j] = new Random().Next(0,11);
         summ[i] = summ[i] + array2d[i,j];
        Console.Write(array2d[i,j] + " ");
       
    }
    Console.WriteLine($" -> {summ[i]}");
}
int min = summ[0];
int minIndex = 0;
for (int i=0; i<summ.Length; i++)
{
    if (min > summ[i])
    {
        min = summ[i];
        minIndex = i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов -> {(minIndex+1)}");