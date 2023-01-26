// 27.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int num)
{
    int sum = 0;
    if (num < 0) num *= -1;
    for (int i = 0; num!= 0; i++)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number} = {sumNumber}");
