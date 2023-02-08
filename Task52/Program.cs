﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}   |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("   |");
    }
}
void PrintArray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {

        if (i < array.Length - 1) Console.Write($"{array[i],5}   |");
        else Console.Write($"{array[i],5}");
    }
    Console.WriteLine("   |");
}
double[] ArrayAverageSumElementsColumnsMatrix(int[,] matrix)
{
    double[] arrAverageValueOfSumElementsInMatrix = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sumElementInColumnsMatrix = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumElementInColumnsMatrix += matrix[i, j];
        }

        arrAverageValueOfSumElementsInMatrix[j] = Math.Round(((double)sumElementInColumnsMatrix / matrix.GetLength(0)), 1, MidpointRounding.ToZero);
    }
    return arrAverageValueOfSumElementsInMatrix;
}

int[,] array2D = GreatMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);

double[] averageValueSumElementsColumnsMatrix = ArrayAverageSumElementsColumnsMatrix(array2D);

Console.WriteLine("Среднее арифметическое столбца: ");
PrintArray(averageValueSumElementsColumnsMatrix);