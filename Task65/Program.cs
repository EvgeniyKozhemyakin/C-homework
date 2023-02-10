// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void NaturalNumbers(int m, int n)
{
    Console.Write($"{m} ");
    if (m == n) return;
    if (m > n) NaturalNumbers(m - 1, n);
    else NaturalNumbers(m + 1, n);
}

Console.WriteLine("Введите первое число :");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int numberSecond = Convert.ToInt32(Console.ReadLine());

while (numberFirst <= 0 || numberSecond <= 0)
{
    Console.WriteLine("Введите первое число :");
    numberFirst = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число :");
    numberSecond = Convert.ToInt32(Console.ReadLine());
}

NaturalNumbers(numberFirst, numberSecond);

