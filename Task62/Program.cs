// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] GreatMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = j + 1;
            }
        }
        if (i > 0)
        {
            matrix[i, matrix.GetLength(1) - 1] = matrix[i - 1, matrix.GetLength(1) - 1] + 1;
            
        }
        if (i == matrix.GetLength(0) - 1)
        {
            for (int j = matrix.GetLength(1) - 1; j > 0; j--) // 5
            {
                matrix[i, j - 1] = matrix[i, j] + 1; //
            }
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

int[,] array2D = GreatMatrixRndInt(6, 6);
PrintMatrix(array2D);