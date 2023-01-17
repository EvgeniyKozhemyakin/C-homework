//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string ReturnThird(int num)
{
    while (num / 100 >= 10)
    {
        num = num / 10;
    }

    if (num < 100) return "третьей цифры нет";
    return (num % 10).ToString();
}

Console.WriteLine("Введите число :");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

string thirdNumb = ReturnThird(number);

Console.WriteLine(thirdNumb);











