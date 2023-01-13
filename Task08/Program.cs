// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите положительное число : ");
int number = Convert.ToInt32(Console.ReadLine()); // 3 10
int numberFirst = number - (number - 1); // 1 10 - 9 = 1

if (number > 1)
{
    for (int i = 0; i < number; i++)
    {
        if (numberFirst % 2 == 0)
        {
            if (numberFirst == 2)
            {
                Console.Write($"{numberFirst}");
                numberFirst++;
            }
            else
            {
                Console.Write($", {numberFirst}");
                numberFirst++;
            }
        }
        else
        {
            numberFirst++;
        }

    }
} else
{
    Console.Write("Вы ввели отрицательное число. Введите положительное число : ");   
}

