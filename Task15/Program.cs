//15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Holiday(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine("Введите число от 1 до 7 :");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay < 1 || numberDay > 7)
{
    Console.WriteLine("Вы ввели не правильное число. Введите число от 1 до 7.");
}
else
{
    bool itHoliday = Holiday(numberDay);
    Console.WriteLine(itHoliday ? "да" : "нет");
}

