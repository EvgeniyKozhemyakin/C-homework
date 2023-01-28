// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}
int QuantityNumbersGreaterZero(int[] array)
{
    int quantity = 0 ; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) quantity ++;
    }
    return quantity;
}
Console.WriteLine("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int quantityNumbersGreaterZer = QuantityNumbersGreaterZero(arr);

PrintArray(arr);
Console.WriteLine($" -> {quantityNumbersGreaterZer}");


