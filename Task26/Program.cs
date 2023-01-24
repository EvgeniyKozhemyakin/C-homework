// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int Sumnum(int num){
    int count = 0;
    if (num < 0) num = num * -1;
    while (num > 0)
    {
        num = num / 10;
        count ++;
    }
    return count;
}

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = Sumnum(number);
Console.WriteLine($"Количество цифр в числе: {number} -> {sumNumber}");

