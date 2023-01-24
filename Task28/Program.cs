// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int factorial = Factorial(number);
    Console.WriteLine($"Факториал числа {number} = {factorial}");
}
else Console.WriteLine("Введите число больше 0");
