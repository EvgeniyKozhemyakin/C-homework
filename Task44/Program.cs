// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}
int[] FibonacciNumbersFromNElements(int num)
{
    int[] array = new int[num];
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
                                     
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
Console.Write("Сколько чисел Фибоначчи вывести на экран? :");
int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacciNumberFromNElem = FibonacciNumbersFromNElements(number);
PrintArray(fibonacciNumberFromNElem);


