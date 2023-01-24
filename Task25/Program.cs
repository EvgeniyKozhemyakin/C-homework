// 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double RaisingAPowerB(double num1, int num2)
{
    double raising = 1;
    for (int i = 0; i < num2; i++)
    {
        raising *= num1;
    }
    return Math.Round(raising,2,MidpointRounding.ToZero);
}

Console.WriteLine("Введите два числа:");

Console.Write("A:");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.Write("B:");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberB <= 0) Console.WriteLine("Некорректный ввод числа B");
else
{
    double raising = RaisingAPowerB(numberA, numberB);
    Console.WriteLine($"{numberA}^{numberB} = {raising}");
}