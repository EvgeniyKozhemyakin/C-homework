// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


bool MultipleNum(int num1)
{
    return num1 % 7 == 0 && num1 % 23 == 0;
}

Console.WriteLine("Введите число :");

int number = Convert.ToInt32(Console.ReadLine());
bool remains = MultipleNum(number);

if (remains)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

