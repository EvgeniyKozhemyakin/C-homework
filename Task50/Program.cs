// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4    1,7 -> такого нет


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

int[,] array2D = GreatMatrixRndInt(3, 4, 0, 10);

Console.WriteLine("Значение какого элемента двумерного массива" +
                  $" [{array2D.GetLongLength(0)} x {array2D.GetLongLength(1)}] вы хотите узнать?");
Console.Write("Номер строки в массиве:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца в массиве:");
int numberColumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numberRow > array2D.GetLongLength(0)
               || numberRow < 1
               || numberColumn > array2D.GetLongLength(1)
               || numberColumn < 1
                ? "Такого элемента нет."
                : "Значение элемента двумерного массива  = " + array2D[numberRow - 1, numberColumn - 1]);
PrintMatrix(array2D);
