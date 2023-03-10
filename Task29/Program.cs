//29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1 ; i++)
    {
        Console.Write($"{arr[i]}, " );
    }
    Console.Write($"{arr[arr.Length - 1]}");
}

int[] arrayRandom = GenerateArray(8, 1, 99);

PrintArray(arrayRandom);
Console.Write(" -> [");
PrintArray(arrayRandom);
Console.Write("]");

