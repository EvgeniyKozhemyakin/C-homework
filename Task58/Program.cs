// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
    Console.WriteLine();
}
int[,] ProductOfTwoMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] matrixProduct = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];

    for (int i = 0; i < matrixProduct.GetLength(0); i++)
    {
        for (int j = 0; j < matrixProduct.GetLength(1); j++)
        {
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                matrixProduct[i, j] += matrixFirst[i, k] * matrixSecond[k, j];                                                                                     //    2 * 1  1*5   
            }
        }
    }
    return matrixProduct;
}

int[,] array2DFirst = GreatMatrixRndInt(3, 2, 0, 5);
int[,] array2DSecond = GreatMatrixRndInt(2, 3, 0, 5);

PrintMatrix(array2DFirst);
PrintMatrix(array2DSecond);

if (array2DFirst.GetLength(0) == array2DSecond.GetLength(1))
{
    int[,] matrixProduct = ProductOfTwoMatrix(array2DFirst, array2DSecond);
    Console.WriteLine("Произведение матриц: ");
    PrintMatrix(matrixProduct);
}
else Console.WriteLine("Чтобы умножить две матрицы, количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");


