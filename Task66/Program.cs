// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//5      //3
int SumNaturalDigits(int num1, int num2)
{
    if (num2 == num1) return num1;
    if (num2 < num1) return SumNaturalDigits(num2, num1);
    return num1 += SumNaturalDigits(num1 + 1, num2);
}

Console.Write("Введите значение M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberM < 1) Console.WriteLine("Введите натуральные числа!");
else
{
    int sumNaturalsDigits = SumNaturalDigits(numberM, numberN);
    Console.WriteLine(sumNaturalsDigits);
}
