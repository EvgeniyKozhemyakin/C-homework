// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int NumberOfEvenNumArray(int[] arr)
{
    int evenNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            evenNum++;
        }
    }
    return evenNum;
}
void PrintArray(int[] arr)
{
    Console.Write($"[{arr[0]}, ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

int[] array = GenerateArray(4, 100, 999);
int numberOfEvenNumbers = NumberOfEvenNumArray(array);

PrintArray(array);
Console.Write($" -> {numberOfEvenNumbers}");
