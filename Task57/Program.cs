// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}
int[] ArrayFromMatrix(int[,] matrix)
{
    int size = matrix.Length;
    int[] arr = new int[size];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
        }
    }
    return arr;

}
void FrequencyDictionary(int[] arr)
{
    int num = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else 
        {
            Console.WriteLine($"{num} встречается {count} раз;");
            num = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{num} встречается {count} раз;");
}

int[,] array2D = GreatMatrixRndInt(3, 4, 0, 10);
int[] arrayElementsMatrix = ArrayFromMatrix(array2D);
Array.Sort(arrayElementsMatrix);
PrintMatrix(array2D);
PrintArray(arrayElementsMatrix);
FrequencyDictionary(arrayElementsMatrix);

