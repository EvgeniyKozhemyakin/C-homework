// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double RaisingAinB (double num1,double num2)
{
    double raising = 1;
    for (int i = 0; i < num2; i++)
    {
        raising *= num1;
    }
    return raising;
}

Console.WriteLine("Введите два числа:");
Console.Write("A:");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("B:");
double numberB = Math.Round(Convert.ToDouble(Console.ReadLine()));
Console.WriteLine(numberB);


double raising = RaisingAinB(numberA,numberB);
Console.WriteLine($"{numberA}^{numberB} = {raising}");