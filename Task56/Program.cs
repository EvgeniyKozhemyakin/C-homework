// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {

        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");

    }
}
int[] ArraySumElementsRow(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumElements = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElements += matrix[i, j];
            arr[i] = sumElements;
        }
    }
    return arr;

}
int[] RowsMinSumInMatrix(int[] arr)
{   
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min == arr[i])
            size++;
    }
    int[] arrRowsSumMinElements = new int[size];

    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == min)
        {
            arrRowsSumMinElements[count] = i + 1;
            count++;
        }
    }
    return arrRowsSumMinElements;
}

int[,] array2D = GreatMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);

int[] sumElementsRow = ArraySumElementsRow(array2D);
int[] rowsMinSumMatrix = RowsMinSumInMatrix(sumElementsRow);

PrintArray(rowsMinSumMatrix);
Console.Write("строка");


