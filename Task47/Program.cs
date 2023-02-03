// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



double[,] GenerateMatrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
        }
    }
    return array;
}
void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],5} |");
            else Console.WriteLine($"{array[i, j],5} |");
        }
    }
}

double[,] matrix2d = GenerateMatrixRndDouble(3, 4, -9.4, 10);
PrintMatrix(matrix2d);