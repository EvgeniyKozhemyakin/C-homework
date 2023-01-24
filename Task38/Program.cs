// 38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int MaxElementsArray(int[] arr)
{
    int max = 0;
    for (int i = 1; i < arr.Length - 1; i++)
    {
        if (arr[i] > arr[max]) max = i;
    }
    return arr[max];
}
int MinElementsArray(int[] arr)
{
    int min = 0;
    for (int i = 1; i < arr.Length - 1; i++)
    {
        if (arr[i] < arr[min]) min = i;
    }
    return arr[min];
}

int[] array = GenerateArray(8, 0, 100);
int maxElements = MaxElementsArray(array);
int minElements = MinElementsArray(array);
int diffBetweenMaxMin = maxElements - minElements ;

PrintArray(array);
Console.Write($"--> {diffBetweenMaxMin}");



