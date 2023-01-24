// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumber(int num)
{
    if (num < 0) num = num * -1;

    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма цифр числа {number} = {sumNumber}");
