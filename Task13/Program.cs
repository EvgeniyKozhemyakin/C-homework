//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdNumber(int num)
{      
    while (num / 100 >= 10)
        {
            num = num / 10;   
        }
        return num % 10;     
}

Console.WriteLine("Введите число :");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int thirdNumb = ThirdNumber(number);

Console.WriteLine(number < 100 ? "третьей цифры нет" : thirdNumb  );









