// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите положительное число : ");

int number = Convert.ToInt32(Console.ReadLine());
string numberFirst = "";
int localNum = number % 2 == 0 ? number : number - 1;

if (localNum >= 1)
{
    for (int i = 2; i <= localNum; i += 2)
    {
        numberFirst += Convert.ToString(i);
        if (i != localNum)
        {
            numberFirst += ",";
        }
    }
    Console.Write($"{numberFirst}");
}
else
{
    Console.Write("Вы ввели отрицательное число или 1. Введите положительное число больше 1 : ");
}

