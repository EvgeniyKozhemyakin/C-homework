// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int SumNumber(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Введите целое положительное число:");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb > 0)
{
    int sumNumber = SumNumber(numb);
    Console.WriteLine($"Сумма чисел от 1 до {numb} = {sumNumber}");
}
else Console.WriteLine($"Введено некорректное значение");




