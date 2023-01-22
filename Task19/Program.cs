// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome (int num)
{
    int temp = num;
    int inverted = 0;
    while (num > 0)
    {   
        inverted = inverted * 10 + num % 10;           
        num = num / 10;        
    }
    return temp == inverted;
}

Console.WriteLine("Введите пятизначное число");
int numb = Convert.ToInt32(Console.ReadLine());

bool palindrome = Palindrome(numb);

if (numb < 10000 || numb > 99999 ) Console.WriteLine("Некорректный ввод");   
else Console.WriteLine(palindrome ? $"{numb} -> да" : $"{numb} -> нет");  



