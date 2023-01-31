// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



double[,] GenerateArrayTwoDimensional(int row, int column, double min, double max)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
        }
    }
    return array;
}
void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write($"[{array[i, j]}, ");
            }
            else if (j > 0 && j < array.GetLength(1) - 1)
            {
                Console.Write($"{array[i, j]}, ");
            }
            else
            {
                Console.Write($"{array[i, j]}] ");
            }

        }
        Console.WriteLine();
    }
}

double[,] arr = GenerateArrayTwoDimensional(3, 4, -10, 10);
PrintArr(arr);