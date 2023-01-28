// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] GenerateArray(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return arr;
}
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}]");
    }
}
double MaxElementsArray(double[] arr)
{
    int max = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[max]) max = i;
    }
    return arr[max];
}
double MinElementsArray(double[] arr)
{
    int min = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[min]) min = i;
    }
    return arr[min];
}

double[] array = GenerateArray(5, 0, 100);
double maxElements = MaxElementsArray(array);
double minElements = MinElementsArray(array);
double diffBetweenMaxMin = Math.Round(maxElements - minElements, 2) ;

PrintArray(array);
Console.Write($" -> Разница между макс и мин = {diffBetweenMaxMin}.");



