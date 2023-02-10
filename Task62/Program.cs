// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] GreatMatrixFilledSpirally(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    int maxValue = rows * columns;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                matrix[i, j] = count;
                count++;
            }
            if (i > 0 && i < matrix.GetLength(0) - 1 && j == matrix.GetLength(1) - 1)
            {
                matrix[i, j] = count;
                count++;
            }
            if (i == matrix.GetLength(0) - 1 && j < matrix.GetLength(1) - 1)
            {
                matrix[i, matrix.GetLength(1) - 1 - j] = count;
                count++;
            }
        }

    }
    int m = matrix.GetLength(0) - 1;
    while (m != 0)
    {
        matrix[m, 0] = count;
        count++;
        m--;
    }
    int k = 1;
    int n = 1;
    while (count <= maxValue)
    {
        matrix[k, n] = count;
        if (matrix[k + 1, n] == 0 && matrix[k, n + 1] != 0) k++;
        else if (matrix[k, n - 1] == 0 && matrix[k, n + 1] != 0) n--;
        else if (matrix[k - 1, n] == 0 && matrix[k, n - 1] != 0) k--;
        else n++;
        count++;
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

int[,] array2D = GreatMatrixFilledSpirally(4, 4);
PrintMatrix(array2D);