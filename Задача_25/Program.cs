// / Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] Arr = GetArray(rows, columns, 0, 9);
PrintArray(Arr);
PrintSum(Arr);

int s=0;
int[] Arr2 = PrintSum(Arr);
for (int i = 0; i < Arr2.Length; i++)
{
    s += Arr2[i];
}

Write($"Сумма элементов по главной диагонали равна {String.Join(" + ", PrintSum(Arr))} = {s}");
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[] PrintSum(int[,] array)
{
    int i = array.GetLength(0);
    int j = array.GetLength(1);
    if (i < j)
    {
        int[] result = new int[i];
        for (int k = 0; k < i; k++)
            result[k] = array[k, k];
        return result;
    }
    else
    {
        int[] result = new int[j];
        for (int k = 0; k < j; k++)
            result[k] = array[k, k];
        return result;
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
