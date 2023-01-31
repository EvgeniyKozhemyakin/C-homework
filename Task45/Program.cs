// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] GreatArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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
int[] ArrayCopy(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;
}

int[] arr = GreatArrayRnd(5, 0, 10);
PrintArray(arr);
int[] arr2 = ArrayCopy(arr);
arr2[2] = 5;
PrintArray(arr2);


