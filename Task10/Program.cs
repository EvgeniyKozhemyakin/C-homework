// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ThreeAverage(int num)
{
    return num / 10 % 10;
}

Console.WriteLine("Введите трехзначное число:");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = ThreeAverage(number);

Console.WriteLine(number < 1000 && number > 99 ? result : "Вы ввели не трехзначное число.");


